using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static bool ValidateMember(String Fname, String Sname, int phone, String Email)
        {
            if (String.IsNullOrEmpty(Fname))
            {
                MessageBox.Show("First Name must not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
