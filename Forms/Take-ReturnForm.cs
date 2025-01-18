using FormBiblioteka.Modules;
using System.Diagnostics;
using System.Text.Json;

namespace FormBiblioteka
{
    public partial class Take_ReturnForm : Form
    {
        public Take_ReturnForm()
        {
            InitializeComponent();
        }

        public void TakeReturnFormLoad(object sender, EventArgs e) { UpdateBookInput(); }
        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            HeroPage heroPage = new();
            heroPage.Show();
        }
        private void SubmitButtonClick(object sender, EventArgs e)
        {
            try
            {
                OperationType operation = (OperationType)Enum.Parse(typeof(OperationType), OperationTypeInput.Text);
                Book book = BookListClass.BookArray.SingleOrDefault(book => book!.Title == BookInput.Text) ?? throw new Exception("Invalid book");
                int amount = (int)NumberOfBooksInput.Value;
                DataManagement.UpdateData(operation, book, amount, BookListClass.BookArray);
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Text = ex.Message;
            }
            finally
            {
                DisplayBooksAmounts();
            }
        }

        private void UpdateBookInput()
        {
            ComboBox bookInput = BookInput;

            BookListClass.BookArray.ForEach(book => { bookInput.Items.Add(book.Title); });
        }

        private void DisplayBooksAmounts(object? sender = null, EventArgs? e = null)
        {
            try
            {
                Book book = BookListClass.BookArray.SingleOrDefault(book => book.Title == BookInput.Text) ?? throw new Exception("Book not found.");
                BooksLeftLabel.Text = $"Books Left: {book.AmountLeft}";
                BooksTakenLabel.Text = $"Books Taken: {book.TakenBooks}";
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Text = ex.Message;
            }
        }
    }
}
