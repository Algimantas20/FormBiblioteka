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

            AppendABookToFile(book);
        }

        private static void AppendABookToFile(Book book)
        {
            const string fileName = @"..\..\..\Duomenys.json";

            List<Book> books;

            // Check if the file exists and load the existing JSON array, if any
            if (File.Exists(fileName))
            {
                string existingJson = File.ReadAllText(fileName);
                books = string.IsNullOrWhiteSpace(existingJson)
                    ? []
                    : JsonSerializer.Deserialize<List<Book>>(existingJson) ?? new List<Book>();
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
            {
                this.Hide();
                HeroPage heroPageForm = new();
                heroPageForm.ShowDialog();
            }
        }
    }

    class Book(string title, string author, DateTime releaseDate, int pageCount, int amount)
    {
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public DateTime ReleaseDate { get; set; } = releaseDate;
        public int PageCount { get; set; } = pageCount;
        public int Amount { get; set; } = amount;
    }
}
