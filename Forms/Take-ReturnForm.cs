using FormBiblioteka.Modules;
using System.Diagnostics;
using System.Text.Json;

namespace FormBiblioteka
{
    public partial class Take_ReturnForm : Form
    {
        List<Book> BookArray = GetBooksFromFile();

        public Take_ReturnForm()
        {
            InitializeComponent();
        }

        public void TakeReturnFormLoad(object sender, EventArgs e) { UpdateBookInput(); }
        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Close();
            HeroPage heroPage = new();
            heroPage.Show();
        }
        private void SubmitButtonClick(object sender, EventArgs e)
        {
            try
            {
                OperationType operation = (OperationType)Enum.Parse(typeof(OperationType), OperationTypeInput.Text);
                Book book = BookArray.SingleOrDefault(book => book!.Title == BookInput.Text)!;
                int amount = (int)NumberOfBooksInput.Value;
                UpdateData(operation, book, amount);
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

            BookArray.ForEach(book => { bookInput.Items.Add(book.Title); });

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
        private void UpdateData(OperationType operation, Book book, int amount)
        {
            try
            {
                switch (operation)
                {
                    case OperationType.Take:
                        if (book.AmountLeft < amount) { return; }

                        book.AmountLeft -= amount;
                        book.TakenBooks += amount;

                        JsonifyData();
                        break;

                    case OperationType.Return:
                        if (book.TakenBooks < amount) { return; }

                        book.AmountLeft += amount;
                        book.TakenBooks -= amount;

                        JsonifyData();
                        break;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Text = ex.Message;
            }
        }
        
        private void JsonifyData()
        {
            const string filePath = @"..\..\..\Duomenys.json";
            string updatedJson = JsonSerializer.Serialize(BookArray, options: new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, updatedJson);
        }

        private void DisplayBooksAmounts(object? sender = null, EventArgs? e = null)
        {
            try
            {
                Book book = BookArray.SingleOrDefault(book => book.Title == BookInput.Text) ?? throw new Exception("Book not found.");
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
