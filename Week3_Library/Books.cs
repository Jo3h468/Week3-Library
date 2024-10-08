namespace Week3_Library
{
    class Book
    {
        private string title; // variable
        private string author; // variable
        private string isbn; // variable

        // Title property to allow access
        // to the title private variable
        public string Title
        {
            get { return Title; } // get method
            set { Title = value; } // set method
        }
        public string Author
        {
            get { return Author; } // get method
            set { Author = value; } // set method
        }
        public string ISBN
        {
            get { return ISBN; } // get method
            set { ISBN = value; } // set method
        }

        // Constructor to add a new book
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;
        }

        // Example of a method within the Book class
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
