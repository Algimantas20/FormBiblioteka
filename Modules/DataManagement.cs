using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FormBiblioteka.Modules
{
    internal class DataManagement
    {
        public static List<Book> GetBooksFromFile()
        {
            const string relativePath = @"..\..\..\Duomenys.json";
            string absolutePath = Path.GetFullPath(relativePath);

            if (!File.Exists(absolutePath))
                return [];

            try
            {
                using var fileStream = new FileStream(absolutePath, FileMode.Open, FileAccess.Read);
                using var reader = new StreamReader(fileStream);

                string jsonContent = reader.ReadToEnd();
                var books = JsonSerializer.Deserialize<List<Book>>(jsonContent);

                return books ?? new List<Book>();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error reading books: {ex.Message}");
                return [];
            }
        }
        public static void UpdateData(OperationType operation, Book book, int amount, List<Book> books)
        {
            switch (operation)
            {
                case OperationType.Take:
                    if (book.AmountLeft < amount) { return; }

                    book.AmountLeft -= amount;
                    book.TakenBooks += amount;

                    JsonifyData(books);
                    break;

                case OperationType.Return:
                    if (book.TakenBooks < amount) { return; }

                    book.AmountLeft += amount;
                    book.TakenBooks -= amount;

                    JsonifyData(books);
                    break;
            }
        }

        public static void AppendABookToFile(Book book)
        {
            const string fileName = @"..\..\..\Duomenys.json";

            List<Book> books;

            if (File.Exists(fileName))
            {
                string existingJson = File.ReadAllText(fileName);
                books = string.IsNullOrWhiteSpace(existingJson)
                    ? []
                    : JsonSerializer.Deserialize<List<Book>>(existingJson)
                    ?? [];
            }
            else
            {
                books = [];
            }

            books.Add(book);

            string updatedJson = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, updatedJson);
        }

        public static void JsonifyData(List<Book> BookArray)
        {
            const string filePath = @"..\..\..\Duomenys.json";
            string updatedJson = JsonSerializer.Serialize(BookArray, options: new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, updatedJson);
        }
    }
}
