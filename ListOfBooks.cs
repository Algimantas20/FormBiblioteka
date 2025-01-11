using System.Text.Json;

namespace FormBiblioteka
{
    public partial class ListOfBooks : Form
    {
        private static List<Book?> BookList = GetBooksFromFile();
        public ListOfBooks()
        {
            InitializeComponent();

            for (int i = 0; i < BookList.Count; i++)
            {
                Book book = BookList[i];
                Button button = new()
                {
                    Text = book.Title,
                    Size = new Size(200, 40),
                    Name = $"BookButton{i}"
                };
                if (i == 0) { button.Location = new Point(10, 50); }
                else if (i == 1) { button.Location = new Point(10, 100); }
                else { button.Location = new Point(10, 50 * i); }

                this.Controls.Add(button);
            }
        }

        private void ListOfBooks_Load(object sender, EventArgs e) { }
        private static List<Book> GetBooksFromFile()
        {
            const string path = @"..\..\..\Duomenys.json";

            if (!File.Exists(path))
            {
                return [];
            }

            try
            {
                string jsonContent = File.ReadAllText(path);

                return JsonSerializer.Deserialize<List<Book>>(jsonContent) ?? new List<Book>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading books: {ex.Message}");
                return [];
            }
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HeroPage heroPageForm = new();
            heroPageForm.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
