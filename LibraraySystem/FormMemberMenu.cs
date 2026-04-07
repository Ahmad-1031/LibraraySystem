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
    public partial class FormMemberMenu : Form
    {
        public FormMemberMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddMember formAddMember = new FormAddMember();
            formAddMember.ShowDialog();
        }

        private void FormUpdateBook_Click(object sender, EventArgs e)
        {
            FormUpdateMember formUpdateMember = new FormUpdateMember();
            formUpdateMember.ShowDialog();

        }

        private void FormRemoveBook_Click(object sender, EventArgs e)
        {
            FormRemoveMember formRemoveMember = new FormRemoveMember();
            formRemoveMember.ShowDialog();
        }
    }
}
