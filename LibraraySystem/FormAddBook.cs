using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraraySystem
{
    public partial class FormAddBook : Form
    {
        public FormAddBook()
        {
            InitializeComponent();
        }

        private void testAdd_Click(object sender, EventArgs e)
        {

            

            /*string sqlQuery = "INSERT INTO BOOKS VALUES (" +
                "1" + "," +
                "'FN'" + "," +
                "'Harry Potter'" + "," +
                "'J.K Rowling'" + "," +
                "'Harry Potter Order Of the Phoneinx'" + "," +
                "'A'" + "," +
                "'N'" + ")";

            Database.ExecuteNonQuery(sqlQuery);*/
            /*Task.Run(() =>
            {


                try
                {
                    using (var conn = Database.OpenConnection())
                    {
                        this.Invoke (() => MessageBox.Show("Connection to Oracle DB Successfull"));
                    }
                }
                catch (Oracle.ManagedDataAccess.Client.OracleException ex)
                {
                    this.Invoke (() => MessageBox.Show(ex.Message));
                }
                catch (Exception ex)
                {
                    this.Invoke (() => MessageBox.Show(ex.ToString()));
                }
            });*/
        }

        private void FormAddBook_Load(object sender, EventArgs e)
        {

        }

        private void AddBookBT_Click(object sender, EventArgs e)
        {
            string title = TboxBookTitle.Text;
            string author = TBoxAuthor.Text;
            string description = TBoxDescription.Text;
            int genre = CBgenre.SelectedIndex;

            if (!Validation.ValidateBook(title, author, description, genre))
            {
                MessageBox.Show("Please Re-enter");
            }
        }
    }
}
