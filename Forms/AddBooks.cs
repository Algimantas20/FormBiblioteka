using FormBiblioteka.Modules;
using System.Text.Json;

namespace FormBiblioteka
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string author = AuthorTextBox.Text;

            bool isValidDate = DateTime.TryParse(ReleaseDateTextBox.Text, out DateTime releaseDate);
            if (!isValidDate) { this.ErrorLabel.Text = "Invalid Release Date"; return; }

            bool isValidPageCount = int.TryParse(PageCountTextBox.Text, out int pageCount);
            if (!isValidPageCount) { this.ErrorLabel.Text = "Invalid Page Count"; return; }

            bool isValidAmount = int.TryParse(AmountTextBox.Text, out int amount);
            if (!isValidAmount) { this.ErrorLabel.Text = "Invalid Amount"; return; }


            Book book = new
            (
                title: title,
                author: author,
                releaseDate: releaseDate,
                pageCount: pageCount,
                amount: amount
            );

            DataManagement.AppendABookToFile(book);
        }



        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            HeroPage heroPage = new();
            heroPage.Show();
        }
    }
}
