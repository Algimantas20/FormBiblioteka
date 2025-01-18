using FormBiblioteka.Forms;

namespace FormBiblioteka
{
    public partial class HeroPage : Form
    {
        public HeroPage()
        {
            InitializeComponent();
        }
        private void AddBookButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            AddBooks addBooksForm = new();
            addBooksForm.ShowDialog();
        }

        private void ListOfBooksButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            ListOfBooks listOfBooksForm = new();
            listOfBooksForm.ShowDialog();
        }

        private void TakeReturnFormButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            Take_ReturnForm takeReturnForm = new();
            takeReturnForm.ShowDialog();
        }

        private void CheckCartFormButtonClick(Object sender, EventArgs e)
        {
            this.Hide();
            CheckCart checkCartForm = new();
            checkCartForm.ShowDialog();
        }
    }
}
