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

        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMemberMenu formMemberMenu = new FormMemberMenu();
            formMemberMenu.ShowDialog();
        }
    }
}
