using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraraySystem
{
    class Loan
    {
        public int LoanID {  get; set; }
        public int MemID { get; set; }
        public int BookID { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime DueDate {  get; set; }
        public DateTime? ReturnedDate {  get; set; }

       

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
            ReturnedDate = null;
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
            string sql = "SELECT COUNT(*) FROM LOANS WHERE MEMID = :id";

            OracleParameter[] parameters = {
                new OracleParameter(":id",memid)
            };

            int number;
            OracleDataReader dr =  Database.ExecuteSingleRowQuery(sql, parameters);
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
            string sql = "INSERT INTO LOANS (LOANID, MEMID, BOOKID, STARTDATE, DUEDATE, RETURNEDDATE)" +
                "VALUES (:loanid, :memid, :bookid, :startdate, :duedate, :returneddate)";
            OracleParameter[] parameters = {
                new OracleParameter(":loanid",LoanID),
                new OracleParameter(":memid",MemID),
                new OracleParameter(":bookid",BookID),
                new OracleParameter(":startdate",StartDate.Date),
                new OracleParameter(":duedate",DueDate.Date),
                new OracleParameter(":returneddate",ReturnedDate)

            };
           
            Database.ExecuteNonQuery(sql, parameters);

        


            


        }

    }
}
