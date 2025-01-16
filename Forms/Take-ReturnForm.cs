using FormBiblioteka.Modules;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace FormBiblioteka
{
    public partial class Take_ReturnForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        List<Book> BookArray = GetBooksFromFile();

        public Take_ReturnForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
            OperationType operation = (OperationType)Enum.Parse(typeof(OperationType), OperationTypeInput.Text);
            Book book = BookArray.SingleOrDefault(book => book!.Title == BookInput.Text)!;
            int amount = (int)NumberOfBooksInput.Value;

            UpdateData(operation, book, amount);
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
        private void JsonifyData()
        {
            const string filePath = @"..\..\..\Duomenys.json";
            string updatedJson = JsonSerializer.Serialize(BookArray, options: new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, updatedJson);
        }
    }
}
