using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class BookStore
    {
        // Properties for BookId and BookName
        public int BookId { get; set; }
        public string BookName { get; set; }

        // Constructor to initialize the BookStore object
        public BookStore(int bookId, string bookName)
        {
            BookId = bookId;
            BookName = bookName;
        }

        // Method to display the book details
        public void Display()
        {
            Console.WriteLine($"Book ID: {BookId}, Book Name: {BookName}");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            // Create a Dictionary to hold book details
            Dictionary<int, BookStore> books = new Dictionary<int, BookStore>();

            // Adding books to the dictionary
            books.Add(1, new BookStore(1, "The Great Gatsby"));
            books.Add(2, new BookStore(2, "1984"));
            books.Add(3, new BookStore(3, "To Kill a Mockingbird"));

            // Displaying the book details
            Console.WriteLine("Book Details:");
            Console.WriteLine("-------------");
            foreach (KeyValuePair<int, BookStore> book in books)
            {
                book.Value.Display();
            }
        }
    }
}
