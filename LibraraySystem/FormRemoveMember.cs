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
    public partial class FormRemoveMember : Form
    {
        public FormRemoveMember()
        {
            InitializeComponent();
            grpMemberID.Visible = false;
            grpMemberName.Visible = false;
            grdMembers.Visible = false;
            grbMemberDetails.Visible = false;
        }

        private static Member DeleteMember;

        private void FormRemoveMember_Load(object sender, EventArgs e)
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

        private void grdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int MemID = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value);

            DeleteMember = Member.GetMember(MemID);

            LabelFirstName.Text = DeleteMember.Fname;
            LabelSurname.Text = DeleteMember.Sname;
            LabelPhone.Text = DeleteMember.Phone.ToString();
            LabelEmail.Text = DeleteMember.Email;

            grbMemberDetails.Visible = true;
        }

        private void RemoveMemberBt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Are you Sure you want to remove Member?\n\n" + DeleteMember.ToString(),
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
                int no_loans = Loan.NumOfLoans(DeleteMember.MemID);
                if(no_loans > 0)
                {
                    MessageBox.Show("Member cannot be removed due to unreturned loans", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DeleteMember.RemoveMember();
                    MessageBox.Show("Member removed successfully", "Remove Book");
                    ResetUI();

                }
                    
                
            }
        }

        public void ResetUI()
        {
            grbMemberDetails.Visible = false;
            LabelFirstName.Text = String.Empty;
            LabelSurname.Text = String.Empty;
            LabelPhone.Text = String.Empty;
            LabelEmail.Text = String.Empty;

            grdMembers.Visible = false;
            grdMembers.DataSource = null;
            grpMemberID.Visible = false;
            grpMemberName.Visible = false;
            TboxMemberIDS.Text = String.Empty;
            TboxNameS.Text = String.Empty;
        }
    }
}
