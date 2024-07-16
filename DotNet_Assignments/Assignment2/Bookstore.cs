using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Bookstore
    {
        // Data members
        public string ISBN;
        public string BookName;
        public string BookTitle;
        public string BookAuthor;
        public int QuantityOfBooks;
        public double BookPrice;

        // Constructor
        public Bookstore(string isbn, string bookName, string bookTitle, string bookAuthor, int quantityOfBooks, double bookPrice)
        {
            ISBN = isbn;
            BookName = bookName;
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            QuantityOfBooks = quantityOfBooks;
            BookPrice = bookPrice;
        }

        // Method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Book Name: {BookName}");
            Console.WriteLine($"Book Title: {BookTitle}");
            Console.WriteLine($"Book Author: {BookAuthor}");
            Console.WriteLine($"Quantity of Books: {QuantityOfBooks}");
            Console.WriteLine($"Book Price: {BookPrice:C}");
        }

        // Method to calculate and display bill amount
        public void DisplayBillAmount()
        {
            double billAmount = QuantityOfBooks * BookPrice;
            Console.WriteLine($"Total Bill Amount: {billAmount:C}");
        }


        // Main Program

        public static void Main()
        {
            // Reading book details from user input
            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine();

            Console.Write("Enter Book Name: ");
            string bookName = Console.ReadLine();

            Console.Write("Enter Book Title: ");
            string bookTitle = Console.ReadLine();

            Console.Write("Enter Book Author: ");
            string bookAuthor = Console.ReadLine();

            Console.Write("Enter Quantity of Books: ");
            int quantityOfBooks = int.Parse(Console.ReadLine());

            Console.Write("Enter Book Price: ");
            double bookPrice = double.Parse(Console.ReadLine());

            // Creating book object with user input
            Bookstore book = new Bookstore(isbn, bookName, bookTitle, bookAuthor, quantityOfBooks, bookPrice);

            // Displaying book details and bill amount
            book.DisplayBookDetails();
            book.DisplayBillAmount();
        }
    }
}
