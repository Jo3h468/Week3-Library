class Book
{
    string Title;
    string Author;
    string ISBN;

    // Example of a constructor that allows us to 'construct' a new
    // Book object
    public Book(string title, string author, string iSBN)
    {
        Title = title;
        Author = author;
        ISBN = iSBN;
    }

    // Example of a method within the Book class
    void DisplayInfo()
    {
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Create a new instance (object) of the Book class
        //Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        book.DisplayInfo();
    }
}

