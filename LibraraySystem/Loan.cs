using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.VoiceCommands;

namespace LibraraySystem
{
    class Loan
    {
        public int LoanID { get; set; }
        public int MemID { get; set; }
        public int BookID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnedDate { get; set; }



        public Loan()
        {
            LoanID = 0;
            MemID = 0;
            BookID = 0;
            StartDate = DateTime.Now;
            DueDate = DateTime.Now;
            ReturnedDate = null;
        }
        public Loan(int loanID, int memberID, int bookID, DateTime startDate, DateTime dueDate)
        {
            LoanID = loanID;
            MemID = memberID;
            BookID = bookID;
            StartDate = startDate;
            DueDate = dueDate;

        }

        public override string ToString()
        {
            string str = "Loan Details:\n\n";

            str += "Loan ID: " + LoanID +
                "\nMember ID: " + MemID +
                "\nBook ID: " + BookID +
                "\nLoan Start Date: " + StartDate +
                "\nLoan Due Date: " + DueDate +
                "\nLoan Returned Date: " + ReturnedDate;

            return str;
        }

        public static int NextLoanID()
        {
            string sqlQuery = "SELECT MAX(LOANID) FROM LOANS";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            int nextID;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextID = 1;
            }
            else
            {
                nextID = dr.GetInt32(0) + 1;
            }

            dr.Close();
            return nextID;
        }

        public static int NumOfLoans(int memid)
        {
            string sql = "SELECT COUNT(*) FROM LOANS WHERE MEMID = :id AND RETURNEDDATE IS NULL";

            OracleParameter[] parameters = {
                new OracleParameter(":id",memid)
            };

            int number;
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sql, parameters);
            dr.Read();

            number = dr.GetInt32(0);


            return number;
        }

        public void AddLoan()
        {
            //Chaning Book Status to 'L' to loan out to member
            string BookStatus = "UPDATE BOOKS SET STATUS = 'L' WHERE BOOKID = :bookid";

            OracleParameter[] parameters2 =
            {
                new OracleParameter(":bookid",BookID)
            };

            Database.ExecuteNonQuery(BookStatus, parameters2);

            //Adding Loan to DB
            string sql = "INSERT INTO LOANS (LOANID, MEMID, BOOKID, STARTDATE, DUEDATE)" +
                "VALUES (:loanid, :memid, :bookid, :startdate, :duedate)";
            OracleParameter[] parameters = {
                new OracleParameter(":loanid",LoanID),
                new OracleParameter(":memid",MemID),
                new OracleParameter(":bookid",BookID),
                new OracleParameter(":startdate",StartDate.Date),
                new OracleParameter(":duedate",DueDate.Date),

            };

            Database.ExecuteNonQuery(sql, parameters);



        }

        public void ReturnLoan()
        {

            string sql = "UPDATE LOANS SET " +
                        "RETURNEDDATE = :rdate " +
                        "WHERE LOANID = :id";
            OracleParameter[] parameters = {
                new OracleParameter(":rdate",ReturnedDate),
                new OracleParameter(":id", LoanID)
            };

            Database.ExecuteNonQuery(sql, parameters);

        }



        public static DataSet FindAllLoan(int id)
        {
            string sql = "SELECT * FROM LOANS WHERE MEMID = :id AND RETURNEDDATE IS NULL";

            OracleParameter[] parameters = {
                new OracleParameter(":id",id)
            };

            return Database.ExecuteMultiRowQuery(sql, parameters);


        }

        public static Loan GetLoan(int loanid) {

            string sql = "SELECT * FROM LOANS WHERE LOANID = :loanid";
            OracleParameter[] parameters = {
                new OracleParameter(":loanid",loanid)
            };
            
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sql, parameters);
            dr.Read();

            int memID = int.Parse(dr.GetString("MEMID"));
            int bookID = int.Parse(dr.GetString("BOOKID"));
            DateTime startDate = DateTime.Parse(dr.GetString("STARTDATE"));
            DateTime dueDate = DateTime.Parse(dr.GetString("DUEDATE"));

            return new Loan(loanid,memID,bookID,startDate,dueDate);
        }
    }
}
