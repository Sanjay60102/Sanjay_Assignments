namespace Assignment3
{
    internal class Program
    {
        /*1.For an Online Bookstore create a class to store book details and display the book details with fields
isbn,bookname,booktitle,bookauthor,quantityofbooks,bookprice.calculate and display the bill amount
[Note: Use Properties]
Note: read multiple book details from the user and calculate the total amount.*/
        int isbn { get; set; }
        string bookname { get; set; }
        string booktitle { get; set; }
        string bookauthor { get; set; }
        int quantityofbooks { get; set; }
        int bookprice { get; set; }



        public void display()
        {
            Console.WriteLine($"isbn:{isbn}\nbookname:{bookname}\nbooktitle:{booktitle}" +
                $"\nbookauthor:{bookauthor}\nquantityofbooks:{quantityofbooks}\nbookprice:{bookprice}");

        }
        public void Accept()
        {


            Console.WriteLine("Enter the isbn,bookname,booktitle,bookauthor,quantityofbooks,bookprice");

            isbn = int.Parse(Console.ReadLine());
            bookname = Console.ReadLine();
            booktitle = Console.ReadLine();
            bookauthor = Console.ReadLine();
            quantityofbooks = int.Parse(Console.ReadLine());
            bookprice = int.Parse(Console.ReadLine());



        }

        static void Main(string[] args)
        {
            int amount = 0;
            Console.WriteLine("Enter the no of books");
            int n = int.Parse(Console.ReadLine());
            Program[] p = new Program[n];
            for (int i = 0; i < n; i++)
            {
                p[i] = new Program();
                p[i].Accept();
                amount += p[i].bookprice * p[i].quantityofbooks;

            }
            Console.WriteLine("Total amount of books =" + amount);

        }

    }
}