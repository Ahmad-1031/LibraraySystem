using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraraySystem
{
    public partial class FormRemoveBook : Form
    {
        public FormRemoveBook()
        {
            InitializeComponent();
            grpBookDetails.Visible = false;
        }

        private Book book;

        private void FormRemoveBook_Load(object sender, EventArgs e)
        {

        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            grdBooks.DataSource = Book.FindBooks(TBoxSearchB.Text).Tables[0];
            if (grdBooks.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found!");
                TBoxSearchB.Focus();
                return;
            }

            grdBooks.Visible = true;
        }

        private void grdBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int BookID = Convert.ToInt32(grdBooks.Rows[grdBooks.CurrentCell.RowIndex].Cells[0].Value);

            book = Book.GetBook(BookID);

            DataSet ds = Genres.getGenres();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                String GenreCode = ds.Tables[0].Rows[i][0].ToString();
                String GenreDescription = ds.Tables[0].Rows[i][1].ToString();



                if (book.Genre == GenreCode)
                {
                    LabelGenre.Text = GenreCode + " - " + GenreDescription;
                    break;
                }
            }

            
            LabelBookTitle.Text = book.Title;
            LabelAuthor.Text = book.Author;
            TboxDescription.Text = book.Description;

            grpBookDetails.Visible = true;

        }

        private void RemoveBookBt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Are you Sure you want to remove Book?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                string status = Book.GetBookStatus(book.Id);
                if(status == "L")
                {
                    MessageBox.Show("Cannot Remove Loaned Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    book.RemoveBook();
                    MessageBox.Show("Book removed successfully", "Remove Book");
                    ResetUI();
                }
               
            }
        }

        public void ResetUI()
        {
            LabelBookTitle.Text = "";
            LabelAuthor.Text = "";
            LabelGenre.Text = "";
            TboxDescription.Text = "";
            grpBookDetails.Visible = false;
            TBoxSearchB.Text = string.Empty;
        }
    }
}
