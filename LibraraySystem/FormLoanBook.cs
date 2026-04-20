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
            grpLoanDetails.Visible = false;




        }

        private Book book;
        private Member member;
        private Loan loan;

        private void FormLoanBook_Load(object sender, EventArgs e)
        {

            LabelLoanID.Text = Loan.NextLoanID().ToString();
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
            grdBooks.DataSource = null;
            grdBooks.DataSource = Book.FindBooksForLoan(TBoxSearchB.Text).Tables[0];
            if (grdBooks.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found!");
                grdBooks.DataSource = null;
                grdBooks.Visible = false;
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
                grdMembers.DataSource = null;
                grdMembers.Visible = false;
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
                grdMembers.DataSource = null;
                grdMembers.Visible = false;
                TboxNameS.Focus();
                return;
            }
            grdMembers.Visible = true;
        }

        private void grdBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            object value = grdBooks.Rows[grdBooks.CurrentCell.RowIndex].Cells[0].Value;

            if (value == null || value == DBNull.Value)
            {
                MessageBox.Show("No Book Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            LabelBookID.Text = BookID.ToString();

            grpBookDetails.Visible = true;
            grpLoanDetails.Visible = true;
        }

        private void grdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            object value = grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value;

            if (value == null || value == DBNull.Value)
            {
                MessageBox.Show("No Member Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int MemID = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value);

            member = Member.GetMember(MemID);

            LabelFirstName.Text = member.Fname;
            LabelSurname.Text = member.Sname;
            LabelPhone.Text = member.Phone.ToString();
            LabelEmail.Text = member.Email;

            LabelMemberID.Text = "M00" + MemID.ToString();

            grbMemberDetails.Visible = true;
            grpLoanDetails.Visible = true;


        }

        private void LoanBookBT_Click(object sender, EventArgs e)
        {
            string loanid = LabelLoanID.Text;
            string bookid = LabelBookID.Text;
            string memberid = LabelMemberID.Text;
            DateTime startdate = DTPstartDate.Value;
            DateTime duedate = DTPdueDate.Value;

            if (!Validation.ValidateLoan(bookid, memberid, startdate, duedate)) {
                return;
            }

            if(Loan.NumOfLoans(int.Parse(memberid.Substring(3))) > 4)
            {
                MessageBox.Show("Member cannot have more than 5 Loans", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loan = new Loan();
            loan.LoanID = int.Parse(loanid);
            book = Book.GetBook(int.Parse(bookid));
            member = Member.GetMember(int.Parse(memberid.Substring(3)));

            loan.BookID = book.Id;
            loan.MemID = member.MemID;
            loan.StartDate = startdate.Date;
            loan.DueDate = duedate.Date;

            DialogResult result = MessageBox.Show(
                    "Are you Sure you want to Add Loan?\n\n" + loan.ToString() + "\n\n" + member.ToString() + "\n\n" + book.ToString(),
                    "Confirm Loan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                loan.AddLoan();
                MessageBox.Show("Loan Added Successfully", "Loan Added",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ResetUI();

            }

        }

        public void ResetUI()
        {

            //Loan Details GroupBox Resets
            grpLoanDetails.Visible = false;
            DTPdueDate.Value = DateTime.Today;
            DTPstartDate.Value = DateTime.Today;
            LabelBookID.Text = "No Book ID";
            LabelMemberID.Text = "No Member ID";
            LabelLoanID.Text = Loan.NextLoanID().ToString();

            //Book Details GroupBox Resets
            grpBookDetails.Visible = false;
            TboxDescription.Text = string.Empty;
            LabelGenre.Text = string.Empty;
            LabelAuthor.Text = string.Empty;
            LabelBookTitle.Text = string.Empty;

            //Member Details GroupBox Resets
            grbMemberDetails.Visible = false;
            LabelEmail.Text = string.Empty;
            LabelPhone.Text = string.Empty;
            LabelSurname.Text = string.Empty;
            LabelFirstName.Text = string.Empty;

            //Books Grid View Reset
            grdBooks.Visible = false;
            grdBooks.DataSource = null;

            //Members Grid View Reset
            grdMembers.Visible = false;
            grdMembers.DataSource = null;

            //Member Name GroupBox Resets
            grpMemberName.Visible= false;
            TboxNameS.Text = string.Empty;

            //Member MemID GroupBOx Resets
            grpMemberID.Visible= false;
            TboxMemberIDS.Text = string.Empty;

        }
    }
}
