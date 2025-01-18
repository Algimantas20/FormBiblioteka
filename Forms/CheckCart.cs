using FormBiblioteka.Modules;
using System.Diagnostics;
using System.Text.Json;

namespace FormBiblioteka.Forms
{
    public partial class CheckCart : Form
    {
        
        public CheckCart()
        {
            InitializeComponent();
        }
 
        private void DisplayTakenBooks(List<Book> takenBookArray)
        {
            
            int xPosition = (BookButtonDisplay.ClientSize.Width - 200) / 2;
            takenBookArray.ForEach(book =>
            {
                int i = takenBookArray.IndexOf(book);
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
            });
        }
        private void DisplayInfo(object sender, EventArgs e)
        {
            Button button = (sender as Button)!;
            Book selectedBook = BookListClass.BookArray.SingleOrDefault(book => book!.Title == button.Text)!;

            this.BookInfoDisplayLabel.Text = $"Title: {selectedBook.Title}\n" +
                                      $"Author: {selectedBook.Author}\n" +
                                      $"Release Date: {selectedBook.ReleaseDate}\n" +
                                      $"Page Count: {selectedBook.PageCount}\n" +
                                      $"Amount: {selectedBook.Amount}\n" +
                                      $"Amount Taken: {selectedBook.TakenBooks}";
        }
        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            HeroPage heroPage = new();
            heroPage.Show();
        }
        private void CheckCart_Load(object sender, EventArgs e)
        {
            List<Book> takenBookArray = BookListClass.BookArray.Where(book => { return book.Amount != book.AmountLeft; }).ToList();
            DisplayTakenBooks(takenBookArray);
        }
    }
}
