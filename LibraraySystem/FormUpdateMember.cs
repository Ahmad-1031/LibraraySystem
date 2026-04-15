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
    public partial class FormUpdateMember : Form
    {
        public FormUpdateMember()
        {
            InitializeComponent();
            grpMemberID.Visible = false;
            grpMemberName.Visible = false;
            grdMembers.Visible = false;
            grbUpdateMember.Visible = false;

        }

        private Member member;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormUpdateMember_Load(object sender, EventArgs e)
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
            int MemID = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value);

            member = Member.GetMember(MemID);

            TboxFirstName.Text = member.Fname;
            TBoxSurname.Text = member.Sname;
            TBoxPhone.Text = member.Phone.ToString();
            TBoxEmail.Text = member.Email;

            grbUpdateMember.Visible = true;

        }

        private void AddMemberBt_Click(object sender, EventArgs e)
        {
            string Fname = TboxFirstName.Text;
            string Sname = TBoxSurname.Text;
            string Phone = TBoxPhone.Text;
            string Email = TBoxEmail.Text;

            if (!Validation.ValidateMember(Fname, Sname, Phone, Email))
            {
                MessageBox.Show("Please Re-Enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Member.MemberExistsForUpdate(Phone.Trim(), Email.Trim(), member.MemID)) {
                MessageBox.Show("Member Already Exists - No Duplicate Members Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            member.Fname = Fname.Trim();
            member.Sname = Sname.Trim();
            member.Phone = Phone.Trim();
            member.Email = Email.Trim();

            member.UpdateMember();
            ResetUI();

            MessageBox.Show(member.ToString(), "Member Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public void ResetUI()
        {
            TboxFirstName.Text = String.Empty;
            TBoxSurname.Text = String.Empty;
            TBoxPhone.Text = String.Empty;
            TBoxEmail.Text = String.Empty;
            grbUpdateMember.Visible = false;
            grdMembers.Visible = false;
            grdMembers.DataSource = null;
            grpMemberID.Visible = false;
            grpMemberName.Visible = false;
            TboxMemberIDS.Text = String.Empty;
            TboxNameS.Text = String.Empty;


        }

        
    }
}
