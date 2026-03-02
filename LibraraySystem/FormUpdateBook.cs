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
    public partial class FormUpdateBook : Form
    {
        public FormUpdateBook()
        {
            InitializeComponent();
            grpBookDetails.Visible = false;
        }

        private void FormUpdateBook_Load(object sender, EventArgs e)
        {

        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            grdBooks.DataSource = Book.FindBooks(TBoxSearchB.Text).Tables[0];
            if (grdBooks.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found!");
                TBoxSearchB.Focus();
                return;
            }

            grdBooks.Visible = true;
        }

        private void grdBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int BookID = Convert.ToInt32(grdBooks.Rows[grdBooks.CurrentCell.RowIndex].Cells[0].Value);

            
        }
    }
}
