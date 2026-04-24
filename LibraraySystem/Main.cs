namespace LibraraySystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookMenu menuAddBook = new BookMenu();
            menuAddBook.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 30, 30, 30);
            tableLayoutPanel1.BackColor = Color.FromArgb(200, 30, 30, 30);
            panelCardBooks.BackColor = Color.FromArgb(230, 35, 40, 55);
            panelCardMembers.BackColor = Color.FromArgb(230, 35, 40, 55);
            panelCardLoans.BackColor = Color.FromArgb(230, 35, 40, 55);
            panelCardAdmin.BackColor = Color.FromArgb(230, 35, 40, 55);

            panelDashboard.BackColor = Color.FromArgb(200, 30, 30, 30);
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMemberMenu formMemberMenu = new FormMemberMenu();
            formMemberMenu.ShowDialog();
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoanMenu formLoanMenu = new FormLoanMenu();
            formLoanMenu.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminMenu formAdminMenu = new FormAdminMenu();
            formAdminMenu.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        Color normal = Color.FromArgb(230, 35, 40, 55);
        Color hover = Color.FromArgb(255, 45, 50, 70);
        private void panelCardBooks_MouseHover(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = hover;
        }

        private void panelCardBooks_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = normal;
        }

        private void panelCardMembers_MouseHover(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = hover;
        }

        private void panelCardMembers_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = normal;
        }

        private void panelCardLoans_MouseHover(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = hover;
        }

        private void panelCardLoans_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = normal;
        }

        private void panelCardAdmin_MouseHover(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = hover;
        }

        private void panelCardAdmin_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = normal;
        }


        

        private void panelCardBooks_MouseClick(object sender, MouseEventArgs e)
        {
            BookMenu menuAddBook = new BookMenu();
            menuAddBook.ShowDialog();
        }

        private void panelCardMembers_MouseClick(object sender, MouseEventArgs e)
        {
            FormMemberMenu formMemberMenu = new FormMemberMenu();
            formMemberMenu.ShowDialog();
        }

        private void panelCardLoans_MouseClick(object sender, MouseEventArgs e)
        {
            FormLoanMenu formLoanMenu = new FormLoanMenu();
            formLoanMenu.ShowDialog();
        }

        private void panelCardAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            FormAdminMenu formAdminMenu = new FormAdminMenu();
            formAdminMenu.ShowDialog();
        }
    }
}
