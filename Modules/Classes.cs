namespace FormBiblioteka.Modules
{
    class Book(string title, string author, DateTime releaseDate, int pageCount, int amount)
    {
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public DateTime ReleaseDate { get; set; } = releaseDate;
        public int PageCount { get; set; } = pageCount;
        public int Amount { get; } = amount;
        public int TakenBooks { get; set; } = 0;
        public int AmountLeft { get; set; } = amount;
    }

    enum OperationType
    {
        Take,
        Return
    }
}
