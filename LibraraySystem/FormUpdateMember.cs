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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormUpdateMember_Load(object sender, EventArgs e)
        {

        }
    }
}
