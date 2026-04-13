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
    public partial class FormLoanBook : Form
    {
        public FormLoanBook()
        {
            InitializeComponent();
            grdBooks.Visible = false;
            grdMembers.Visible = false;
            grpMemberID.Visible = false;
            grpMemberName.Visible = false;
            grpBookDetails.Visible = false;
            grbMemberDetails.Visible = false;




        }

        private Book book;
        private Member member;

        private void FormLoanBook_Load(object sender, EventArgs e)
        {

        }

        private void OPMemID_Click(object sender, EventArgs e)
        {
            grpMemberName.Visible = false;
            grpMemberID.Visible = true;
        }

        private void OPName_Click(object sender, EventArgs e)
        {
            grpMemberID.Visible = false;
            grpMemberName.Visible = true;
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

        private void SearchMemberIDBt_Click(object sender, EventArgs e)
        {
            string id = TboxMemberIDS.Text.Trim().ToUpper();

            if (!Validation.ValidMemberID(id))
            {
                MessageBox.Show("Please Re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int intID = int.Parse(id.Substring(2));



            grdMembers.DataSource = null;
            grdMembers.DataSource = Member.FindMemberByID(intID).Tables[0];

            if (grdMembers.Rows.Count == 1)
            {
                MessageBox.Show("No Member Found!");
                TboxNameS.Focus();
                return;
            }

            grdMembers.Visible = true;
        }

        private void SearchNameBt_Click(object sender, EventArgs e)
        {
            string name = TboxNameS.Text;
            if (!Validation.ValidNameSearch(name))
            {
                MessageBox.Show("Please Re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grdMembers.DataSource = null;
            grdMembers.DataSource = Member.FindMemberByName(name).Tables[0];

            if (grdMembers.Rows.Count == 1)
            {
                MessageBox.Show("No Member Found!");
                grdMembers = null;
                TboxNameS.Focus();
                return;
            }
            grdMembers.Visible = true;
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
    }
}
