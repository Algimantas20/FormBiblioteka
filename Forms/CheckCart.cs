using FormBiblioteka.Modules;
using System.Diagnostics;
using System.Text.Json;

namespace FormBiblioteka.Forms
{
    public partial class CheckCart : Form
    {
        private static List<Book> takenBookArray = GetBooksFromFile();
        public CheckCart()
        {
            InitializeComponent();
            DisplayTakenBooks();
        }
        private static List<Book> GetBooksFromFile()
        {
            const string path = @"..\..\..\Duomenys.json";

            if (!File.Exists(path)) { return []; }

            try
            {
                string jsonContent = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<Book>>(jsonContent)!
                    .Where(book =>
                    {
                        return book.Amount != book.AmountLeft;
                    }).ToList() ?? [];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading books: {ex.Message}");
                return [];
            }
        }
        private void DisplayTakenBooks()
        {
            BookButtonDisplay.Controls.Clear();
            int xPosition = (BookButtonDisplay.ClientSize.Width - 200) / 2;
            takenBookArray.ForEach(book =>
            {
                Debug.WriteLine($"Adding {book.Title}");
                int i = takenBookArray.IndexOf(book);
                Button button = new()
                {
                    Text = book.Title,
                    Size = new Size(200, 40),
                    Location = new Point(xPosition, 10 + (50 * i)),
                    Name = $"BookButton{i}",
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.White
                };
                BookButtonDisplay.Controls.Add(button);
                Debug.WriteLine($"Added {book.Title}");
            });
        }
        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HeroPage heroPageForm = new();
            heroPageForm.ShowDialog();
        }
        private void RefreshBookList()
        {
            takenBookArray = GetBooksFromFile();
            DisplayTakenBooks();
        }
        private void CheckCart_Load(object sender, EventArgs e)
        {
            RefreshBookList();
        }
    }
}
