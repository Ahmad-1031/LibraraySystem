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
    }
}
