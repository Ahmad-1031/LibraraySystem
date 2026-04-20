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
    public partial class FormAdminMenu : Form
    {
        public FormAdminMenu()
        {
            InitializeComponent();
        }

        private void PopularGenresBt_Click(object sender, EventArgs e)
        {
            FormPopularGenres formPopularGenres = new FormPopularGenres();
            formPopularGenres.ShowDialog();
        }

        private void MonthlyFinesBt_Click(object sender, EventArgs e)
        {
            FormMonthlyFines formMonthlyFines = new FormMonthlyFines();
            formMonthlyFines.ShowDialog();
        }
    }
}
