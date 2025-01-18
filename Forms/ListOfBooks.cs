using FormBiblioteka.Modules;
using System.Text.Json;

namespace FormBiblioteka
{
    public partial class ListOfBooks : Form
    {
        public ListOfBooks()
        {
            InitializeComponent();
        }
        private void DisplayBooks()
        {

            int xPosition = (BookButtonDisplay.ClientSize.Width - 200) / 2;
            for (int i = 0; i < BookListClass.BookArray.Count; i++)
            {


                Book book = BookListClass.BookArray[i];
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

        private void DisplayInfo(object sender, EventArgs e)
        {
            Button button = (sender as Button)!;
            Book selectedBook = BookListClass.BookArray.SingleOrDefault(book => book!.Title == button.Text)!;

            this.BookInfoLabel.Text = $"Title: {selectedBook.Title}\n" +
                                      $"Author: {selectedBook.Author}\n" +
                                      $"Release Date: {selectedBook.ReleaseDate}\n" +
                                      $"Page Count: {selectedBook.PageCount}\n" +
                                      $"Amount: {selectedBook.Amount}\n" +
                                      $"Amount Left: {selectedBook.AmountLeft}";
        }
        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            HeroPage heroPage = new();
            heroPage.Show();
        }
        private void ListOfBooks_Load(object sender, EventArgs e)
        {
            DisplayBooks();
        }
    }
}
