﻿using System.Text.Json;

namespace FormBiblioteka
{
    public partial class ListOfBooks : Form
    {
        private static List<Book?> BookList = GetBooksFromFile();
        public ListOfBooks()
        {
            InitializeComponent();
            DisplayBooks();
        }

        private void ListOfBooks_Load(object sender, EventArgs e) { }
        private static List<Book> GetBooksFromFile()
        {
            const string path = @"..\..\..\Duomenys.json";

            if (!File.Exists(path)) {  return []; }

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

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            HeroPage heroPageForm = new();
            heroPageForm.ShowDialog();
        }
        private void DisplayBooks()
        {

            for (int i = 0; i < BookList.Count; i++)
            {
                Book book = BookList[i];
                Button button = new()
                {
                    Text = book.Title,
                    Size = new Size(200, 40),
                    Location = new Point(10, 50 + (50 * i)),
                    Name = $"BookButton{i}"
                };

                button.Click += (sender, e) => { DisplayInfo(sender, e); };

                this.Controls.Add(button);
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
                                      $"Amount:{selectedBook.Amount}";
        }
    }
}
