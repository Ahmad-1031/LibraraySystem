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
    public partial class MenuAddBook : Form
    {
        public MenuAddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook();
            formAddBook.ShowDialog();
        }

        private void FormUpdateBook_Click(object sender, EventArgs e)
        {
            FormUpdateBook formUpdateBook = new FormUpdateBook();
            formUpdateBook.ShowDialog();
        }
    }
}
