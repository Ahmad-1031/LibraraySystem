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
            MenuAddBook menuAddBook = new MenuAddBook();
            menuAddBook.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
