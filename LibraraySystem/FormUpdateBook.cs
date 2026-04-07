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
    public partial class FormUpdateBook : Form
    {
        public FormUpdateBook()
        {
            InitializeComponent();
            grdBooks.Visible = false;
            grpBookDetails.Visible = false;
        }

        private Book book;

        private void FormUpdateBook_Load(object sender, EventArgs e)
        {

        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            grdBooks.DataSource = Book.FindBooks(TBoxSearchB.Text).Tables[0];
            if (grdBooks.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found!");
                TBoxSearchB.Focus();
                return;
            }

            grdBooks.Visible = true;
        }

        private void grdBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void grdBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int BookID = Convert.ToInt32(grdBooks.Rows[grdBooks.CurrentCell.RowIndex].Cells[0].Value);

            book = Book.GetBook(BookID);

           

          
            TboxBookTitle.Text = book.Title;
            TBoxAuthor.Text = book.Author;
            TBoxDescription.Text = book.Description;

            CBgenre.Items.Clear();

            DataSet ds = Genres.getGenres();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                CBgenre.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);

            }

            String genre = book.Genre;

            for (int i = 0; i < CBgenre.Items.Count; i++)
            {
                if (CBgenre.Items[i].ToString().StartsWith(genre + " -"))
                {
                    CBgenre.SelectedIndex = i;
                    break;
                }
            }

            grpBookDetails.Visible = true;




        }

        private void UpdateBookBT_Click(object sender, EventArgs e)
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

            String UpdatedGenre = CBgenre.Items[genre].ToString();

            book.Title = title;
            book.Author = author;
            book.Description = description;
            book.Genre = UpdatedGenre.Substring(0, 2);
            //MessageBox.Show(book.Id.ToString());

            book.UpdateBook();


            MessageBox.Show("\n" + book.ToString() + "\nBook Updated Successfully");

            grpBookDetails.Visible = false;
            ResetUI();

            //MessageBox.Show(UpdatedBook.Id.ToString());


        }

        public void ResetUI()
        {
            TboxBookTitle.Text = string.Empty;
            TBoxAuthor.Text = string.Empty;
            TBoxDescription.Text = string.Empty;
            CBgenre.SelectedIndex = -1;
            grdBooks.DataSource = null;
            TboxBookTitle.Clear();



        }
    }
}
