namespace Bookstore
{
    using System.Collections;

    public struct Book
    {
        public string Title{ get;}
        public string Author{ get;}
        public decimal Price{ get;}
        public bool Paperback{ get;}

        public Book(string title, string author, decimal price, bool paperback)
        { 
            Title = title;
            Author = author;
            Price = price;
            Paperback = paperback;
        }

    }
    public delegate void ProcessBookCallback(Book book);

    public class BookDB
    {
        ArrayList list = new();    

        public void AddBook(string title, string author, decimal price, bool paperback)
        {
            list.Add(new Book(title, author, price,paperback));
        }

        public void ProcessPaperbackBooks(ProcessBookCallback processBook)
        {
            foreach (Book b in list) if (b.Paperback) processBook(b);
        }        
    }    
}

namespace BookTestClient
{
    using Bookstore;

    class PriceTotaller
    {
        int countBooks = 0;
        decimal priceBooks = 0.0m;

        internal void AddBookToTotal(Book book)
        {
            countBooks++;
            priceBooks += book.Price;
        }

        internal decimal AveragePrice()
        {
            return priceBooks/countBooks;
        }
        
    }

    class Test
    {
        static void PrintTitle(Book b)
        {
            Console.WriteLine($" Title -> {b.Title}");
        }

        static void Main()
        {
            BookDB bookDB = new();
            AddSomeBooks(bookDB);

            Console.WriteLine("Paperback Book Titles: ");

            //Using the delegate to print the titles
            bookDB.ProcessPaperbackBooks(PrintTitle);

            PriceTotaller totaller = new();

            //Using the delegate to add the price to the totaller
            bookDB.ProcessPaperbackBooks(totaller.AddBookToTotal);

            Console.WriteLine("Avarage Paperback Book Price: ${0:#.##}", totaller.AveragePrice());
        }

        static void AddSomeBooks(BookDB bookDB)
        {
            bookDB.AddBook("The C Programming Language", "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
            bookDB.AddBook("The Unicode Standard 2.0", "The Unicode Consortium", 39.95m, true);
            bookDB.AddBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95m, false);
            bookDB.AddBook("Dogbert's Clues for the Clueless", "Scott Adams", 12.00m, true);
        }
    }
}