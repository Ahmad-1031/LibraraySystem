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
            TBoxBookID.Text = Book.GetNextBookID().ToString("0000");

            CBgenre.Items.Clear();

            DataSet ds = Genres.getGenres();



            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {
                CBgenre.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
                
            }



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
                return;
            }

            if(Book.BookExistsForInsert(title.Trim(), author.Trim()))
            {
                MessageBox.Show("Book Already Exists!", "Duplicate Book");
                return;
            }

            string selectedGenre = CBgenre.SelectedItem.ToString().Substring(0, 2);
            
            Book b1 = new Book(Convert.ToInt32(TBoxBookID.Text),title.Trim(),author.Trim(),description.Trim(),selectedGenre);
            b1.AddBook();
            MessageBox.Show("\n" + b1.ToString(), "Book Added Successfully");
            ResetUI();

            MessageBox.Show(b1.ToString());


            



        }

        public void ResetUI()
        {
            TboxBookTitle.Text = string.Empty;
            TBoxAuthor.Text = string.Empty;
            TBoxBookID.Text = string.Empty;
            TBoxDescription.Text = string.Empty;
            CBgenre.SelectedIndex = -1;
            TboxBookTitle.Clear();
            TBoxBookID.Text = Book.GetNextBookID().ToString("0000");


        }
    }
}
