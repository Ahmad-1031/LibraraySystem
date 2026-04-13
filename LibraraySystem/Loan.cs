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
    }
}
