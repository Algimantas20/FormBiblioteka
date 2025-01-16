using FormBiblioteka.Modules;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace FormBiblioteka
{
    public partial class AddBooks : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public AddBooks()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

            AppendABookToFile(book);
        }

        private static void AppendABookToFile(Book book)
        {
            const string fileName = @"..\..\..\Duomenys.json";

            List<Book> books;

            if (File.Exists(fileName))
            {
                string existingJson = File.ReadAllText(fileName);
                books = string.IsNullOrWhiteSpace(existingJson)
                    ? []
                    : JsonSerializer.Deserialize<List<Book>>(existingJson)
                      ?? [];
            }
            else
            {
                books = [];
            }

            books.Add(book);

            string updatedJson = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, updatedJson);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HeroPage heroPage = new();
            heroPage.Show();
        }
    }
}
