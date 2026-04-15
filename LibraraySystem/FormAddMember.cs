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
    public partial class FormAddMember : Form
    {
        

        public FormAddMember()
        {
            InitializeComponent();
            
        }

        private Member member;
       

        private void FormAddMember_Load(object sender, EventArgs e) {
            member = new Member(0, "", "", "", "");
            member.MemID = Member.NextMemID();
            TBoxMemID.Text = "M00" + member.MemID.ToString();
            
        }
  


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddMemberBt_Click(object sender, EventArgs e)
        {
            String Fname = TboxFirstName.Text;
            String Sname = TBoxSurname.Text;
            String Phone = TBoxPhone.Text;
            String Email = TBoxEmail.Text;

            if (!Validation.ValidateMember(Fname, Sname, Phone, Email))
            {
                MessageBox.Show("Please Re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Member.MemberExistsForInsert(Phone.Trim(), Email.Trim()))
            {
                MessageBox.Show("Member Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            member.Fname = Fname.Trim();
            member.Sname = Sname.Trim();
            member.Phone = Phone.Trim();
            member.Email = Email.Trim();
            member.AddMember();

            MessageBox.Show("Member Added Successfully","Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
            ResetUI();






        }

        public void ResetUI()
        {
            TboxFirstName.Text = string.Empty;
            TBoxSurname.Text = string.Empty;
            TBoxPhone.Text = string.Empty;
            TBoxEmail.Text = string.Empty;
            TBoxMemID.Text = "M00" + Member.NextMemID();

        }
    }
}
