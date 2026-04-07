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
    }
}
