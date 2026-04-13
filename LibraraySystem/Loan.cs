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
        public Member Member { get; set; }
        public Book Book { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime DueDate {  get; set; }
        public DateTime? ReturnedDate {  get; set; }

       

        public Loan(int loanID, Member member, Book book, DateTime startDate, DateTime dueDate)
        {
            LoanID = loanID;
            Member = member;
            Book = book;
            StartDate = startDate;
            DueDate = dueDate;
            ReturnedDate = null;
        }

        public override string ToString()
        {
            string str = "Loan Details:\n\n";

            str += "Loan ID: " + LoanID +
                   "\n\nMember Details:\n";

            if (Member != null) {
                str += Member.ToString();
            }
            else
            {
                str += "\nNo Member Found";
            }
            str += "\n\nBook Details:\n";

            if (Book != null) {
                str += Book.ToString();
            }
            else
            {
                str += "No Book Found";
            }
            str +="\nLoan Start Date: " + StartDate +
                "\nLoan Due Date: " + DueDate +
                "\nLoan Returned Date: " + ReturnedDate;

            return str;
        }
    }
}
