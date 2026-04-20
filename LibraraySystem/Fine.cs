using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraraySystem
{
    class Fine
    {
        public int FineID {  get; set; }
        public int LoanID { get; set; }
        public double Amount {  get; set; }
        public DateTime FineDate { get; set; }

        public Fine()
        {
            FineID = 0;
            LoanID = 0;
            Amount = 0;
            FineDate = DateTime.Now;
        }

        public Fine(int LoanId, double amount, DateTime Finedate)
        {
            FineID = nextFineID();
            LoanID = LoanId;
            Amount = amount;
            FineDate = Finedate;
        }

        public override string ToString()
        {
            string str = "Fine Details:\n\n" +
                         $"Fine ID: {FineID}\n" +
                         $"Loan ID: {LoanID}" +
                         $"Fine Amount: € {Amount}" +
                         $"Fine Date: {FineDate}";
            return str;
        }

        public static int nextFineID()
        {
            int nextID;
            string sql = "SELECT MAX(FINEID) FROM FINES";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sql);
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

        public void AddFine()
        {
            string sql = "INSERT INTO FINES (FINEID,LOANID,AMOUNT,FINEDATE)" +
                         "VALUES (:fineID, :loanID, :amount, :fineDate)";

            OracleParameter[] parameters = {
                new OracleParameter(":fineID",FineID),
                new OracleParameter(":loanID",LoanID),
                new OracleParameter(":amount",Amount),
                new OracleParameter(":fineDate",FineDate)
            };

            Database.ExecuteNonQuery(sql, parameters);
        }
    }
}
