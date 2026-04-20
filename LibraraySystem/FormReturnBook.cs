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
    public partial class FormReturnBook : Form
    {
        public FormReturnBook()
        {
            InitializeComponent();
            grpMemberID.Visible = false;
            grpMemberName.Visible = false;

            grdMembers.Visible = false;
            grdLoans.Visible = false;


        }

        private Loan updateLoan;

        private void FormReturnBook_Load(object sender, EventArgs e)
        {

        }

        private void OPMemID_Click(object sender, EventArgs e)
        {
            grpMemberID.Visible = true;
            grpMemberName.Visible = false;
        }

        private void OPName_Click(object sender, EventArgs e)
        {
            grpMemberName.Visible = true;
            grpMemberID.Visible = false;
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

        private void grdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            object value = grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value;

            if(value == null || value == DBNull.Value)
            {
                MessageBox.Show("No Member Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int MemberID = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value);
            

            grdLoans.DataSource = null;
            grdLoans.DataSource = Loan.FindAllLoan(MemberID).Tables[0];

            if (grdLoans.Rows.Count == 1)
            {
                MessageBox.Show("No Loans Found", "No Loans", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                grdLoans.Visible = true;
            }

        }

        private void grdLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = grdLoans.Rows[grdLoans.CurrentCell.RowIndex].Cells[0].Value;

            if (value == null || value == DBNull.Value)
            {
                MessageBox.Show("No Loan Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LoanID = Convert.ToInt32(grdLoans.Rows[grdLoans.CurrentCell.RowIndex].Cells[0].Value);


            updateLoan = Loan.GetLoan(LoanID);

            LabelLoanID.Text = updateLoan.LoanID.ToString();
            LabelMemberID.Text = updateLoan.MemID.ToString();
            LabelBookID.Text = updateLoan.BookID.ToString();
            LabelStartDate.Text = updateLoan.StartDate.ToString();
            LabelDueDate.Text = updateLoan.DueDate.ToString();
        }

        private void ReturnLoanBt_Click(object sender, EventArgs e)
        {
            string LoanID = LabelLoanID.Text;
            string MemberID = LabelMemberID.Text;
            string BookID = LabelBookID.Text;
            string startDate = LabelStartDate.Text;
            string dueDate = LabelDueDate.Text;
            DateTime returnDate = DTPReturnDate.Value;

            if (!Validation.ValidateReturnLoan(LoanID, startDate, dueDate, returnDate))
            {
                return;
            }

            int IntLoanID = int.Parse(LoanID);
            int IntMemberID = int.Parse(MemberID);
            int IntBookID = int.Parse(BookID);

            DateTime DstartDate = DateTime.Parse(startDate);
            DateTime DdueDate = DateTime.Parse(dueDate);

            updateLoan = Loan.GetLoan(IntLoanID);
            updateLoan.ReturnedDate = returnDate.Date;

            if (updateLoan.ReturnedDate > updateLoan.DueDate) {

                Fine fine = new Fine(IntLoanID, 10.00, DateTime.Now.Date);
                MessageBox.Show($"Over Due Loan - Fine Amount €10\n\n{fine.ToString()}","Over Due Loan",MessageBoxButtons.OK, MessageBoxIcon.Information);
                fine.AddFine();
            }

            updateLoan.ReturnLoan();
            
            

            MessageBox.Show("Loan Returned!","Loan Return",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
