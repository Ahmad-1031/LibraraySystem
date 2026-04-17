using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net.Mail;

namespace LibraraySystem
{
    class Validation
    {
        public static bool ValidateBook(string title,string author,string Description,int genre)
        {
            if (String.IsNullOrEmpty(title))
            {
                MessageBox.Show("Title must not be empty!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(author))
            {
                MessageBox.Show("Author must not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (String.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Description must not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(genre == -1)
            {
                MessageBox.Show("No genre selected!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if (title.Length < 5)
            {
                MessageBox.Show("Title must have more than 5 characters!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if(author.Length < 5)
            {
                MessageBox.Show("Author must have more than 5 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Description.Length < 10)
            {
                MessageBox.Show("Description must have more than 10 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool ValidateMember(String Fname, String Sname, String phone, String Email)
        {

            String FirstName = ValidName(Fname, "First Name");
            if (FirstName != null) {
                MessageBox.Show(FirstName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            String Surname = ValidName(Sname, "SurName");
            if (Surname != null) {
                MessageBox.Show(Surname, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            String PhoneNumber = ValidPhone(phone, "Phone Number");
            if (PhoneNumber != null) {
                MessageBox.Show(PhoneNumber, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool EmailAdd = ValidEmail(Email);
            if (EmailAdd == false) {
                MessageBox.Show("Inncorrect Email Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




            return true;
        }

        private static String ValidName (String name, String fieldName)
        {

            if(String.IsNullOrEmpty(name))
            {
                return $"{fieldName} must not be empty!";
            }

            if (name.Length < 2 || name.Length > 25)
            {
                return $"{fieldName} must be between 2 and 25 characters";
                
            }

            for (int i = 0; i < name.Length; i++) {
                char c = name[i];

                if(!(char.IsLetter(c) || c == ' ' || c == '\''))
                {
                    return $"{fieldName} contains invalid characters";
                }
            }

            return null;

        }

        private static String ValidPhone(String phone, String fieldName) {

            if(phone.Length < 9 || phone.Length > 13)
            {
                return $"{fieldName} must be between 9 and 13 digits!";
            }

            for (int i = 0; i < phone.Length; i++) {

                if (!char.IsDigit(phone[i])) {
                    return $"{fieldName} must contain digits only!";
                    break;
                }
            }

            return null;
            
        }

        private static bool ValidEmail(String email)
        {
            try
            {
                var address = new MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidMemberID(String name)
        {
            if(name.Length < 3)
            {
                MessageBox.Show("Member ID must be longer than 3 chars!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
 
            }

            if (name.Length > 3)
            {
                char FirstChar = name[0];
                char SecondChar = name[1];
                char ThirdChar = name[2];
                if (char.ToUpper(FirstChar) != 'M')
                {
                    MessageBox.Show("Member ID must begin with 'M' or 'm'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (SecondChar != '0' || ThirdChar != '0')
                {
                    MessageBox.Show("Second & Third Char must be Zeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                for (int i = 3; i < name.Length; i++) {
                    if (!char.IsDigit(name[i])) {
                        MessageBox.Show("Member ID must contain all numbers after 'M'/'m'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }




            return true;
        }

        public static bool ValidNameSearch(String name)
        {
            if (name.Length > 0)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    char c = name[i];
                    if (char.IsDigit(c))
                    {
                        MessageBox.Show("Name Must not have Numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                        
                    }


                    if (!(char.IsLetter(c) || c == '\''))
                    {
                        MessageBox.Show("Name contains invalid chars! " + "[" + c + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                        
                    }
                }
            }

            return true;
        }

        public static bool ValidateLoan(string bookid,string memberid, DateTime startdate, DateTime duedate)
        {
            if (bookid == "No Book ID")
            {
                MessageBox.Show("No Book Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (memberid == "No Member ID")
            {
                MessageBox.Show("No Member Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(startdate.Date < DateTime.Today)
            {
                MessageBox.Show("Start Date must not be in the past", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (startdate.Date > DateTime.Today.AddDays(14)) {
                MessageBox.Show("Start Date must not exceed 2 weeks from today", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (duedate.Date < startdate.Date) {
                MessageBox.Show("Due Date Must be after Start Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(duedate > startdate.Date.AddDays(14))
            {
                MessageBox.Show("Loan Cannot be longer than 2 weeks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool ValidateReturnLoan(string loanid, string startdate, string duedate, DateTime returndate) {

            if (string.IsNullOrWhiteSpace(loanid) || loanid == "No Loan Selected") {
                MessageBox.Show("No Loan Selected! - Please Select Loan","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                DateTime TstartDate = DateTime.Parse(startdate);
                DateTime TdueDate = DateTime.Parse(duedate);

                if (returndate.Date < TstartDate.Date) {
                    MessageBox.Show("Return Date cannot be before loan start date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (returndate.Date > DateTime.Today) {
                    MessageBox.Show("Return Date Cannot be in the future!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

                return true;
        }
    }
}
