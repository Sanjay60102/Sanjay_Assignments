namespace Assignment2
{

    class Accounts
    {
        // Data members
        private int accountNumber;
        private string customerName;
        private string accountType;
        private char transactionType;
        private int amount;
        private int balance;

        // Method to accept account details
        public void Accept()
        {
            Console.Write("Enter Account Number: ");
            accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            customerName = Console.ReadLine();

            Console.Write("Enter Account Type (e.g., Savings, Current): ");
            accountType = Console.ReadLine();
        }

        // Method to handle deposit transactions
        public void Credit(int amount)
        {
            balance = balance + amount;
        }

        // Method to handle withdrawal transactions
        public void Debit(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        // Method to display account details
        public void ShowData()
        {
            Console.WriteLine("\nAccount Details");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Current Balance: {balance}");
        }

        // Main method
        static void Main(string[] args)
        {
            Accounts account = new Accounts();
            account.Accept();

            Console.Write("Enter Transaction Type (d for deposit, w for withdrawal): ");
            char transactionType = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (transactionType == 'd')
            {
                account.Credit(amount);
            }
            else if (transactionType == 'w')
            {
                account.Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type!");
            }

            account.ShowData();
        }
    }
}
