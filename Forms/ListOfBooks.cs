using FormBiblioteka.Modules;
using System.Text.Json;

namespace FormBiblioteka
{
    public partial class ListOfBooks : Form
    {
        private static List<Book> BookList = GetBooksFromFile();
        public ListOfBooks()
        {
            InitializeComponent();
        }
        private void DisplayBooks()
        {

            int xPosition = (BookButtonDisplay.ClientSize.Width - 200) / 2;
            for (int i = 0; i < BookList.Count; i++)
            {


                Book book = BookList[i];
                Button button = new()
                {
                    Text = book.Title,
                    Size = new Size(200, 40),
                    Location = new Point(xPosition, 10 + (50 * i)),
                    Name = $"BookButton{i}",
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.White,
                };

                button.Click += (sender, e) => { DisplayInfo(sender!, e); };

                BookButtonDisplay.Controls.Add(button);
            }
        }
        private void RefreshBookList()
        {
            BookList = GetBooksFromFile();
            DisplayBooks();
        }
        private static List<Book> GetBooksFromFile()
        {
            const string path = @"..\..\..\Duomenys.json";

            if (!File.Exists(path)) { return []; }

            try
            {
                string jsonContent = File.ReadAllText(path);

                return JsonSerializer.Deserialize<List<Book>>(jsonContent) ?? [];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading books: {ex.Message}");
                return [];
            }
        }
        private void DisplayInfo(object sender, EventArgs e)
        {
            Button button = (sender as Button)!;
            Book selectedBook = BookList.SingleOrDefault(book => book!.Title == button.Text)!;

            this.BookInfoLabel.Text = $"Title: {selectedBook.Title}\n" +
                                      $"Author: {selectedBook.Author}\n" +
                                      $"Release Date: {selectedBook.ReleaseDate}\n" +
                                      $"Page Count: {selectedBook.PageCount}\n" +
                                      $"Amount: {selectedBook.Amount}\n" +
                                      $"Amount Left: {selectedBook.AmountLeft}";
        }
        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HeroPage heroPageForm = new();
            heroPageForm.ShowDialog();
        }
        private void ListOfBooks_Load(object sender, EventArgs e)
        {
            RefreshBookList();
        }
    }
}
