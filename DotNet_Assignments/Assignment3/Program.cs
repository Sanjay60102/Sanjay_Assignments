namespace Assignment3
{
    class Person
    {
        // Properties
        public string FirstName;
        public string LastName;
        public string Email;
        public DateTime DateOfBirth;

        // Constructor accepting all four parameters
        public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
        }

        // Constructor accepting first name, last name, and email
        public Person(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = DateTime.MinValue; // Default value
        }

        // Constructor accepting first name, last name, and date of birth
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = string.Empty; // Default value
        }

        // Method to accept details
        public void AcceptDetails(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
        }

        // Method to display details
        public void Display()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        }
        static void Main()
        {
            // Creating instances of Person using different constructors
            Person person1 = new Person("John", "Doe", "john.doe@example.com", new DateTime(1990, 5, 15));
            Person person2 = new Person("Jane", "Smith", "jane.smith@example.com");
            Person person3 = new Person("Alice", "Johnson", new DateTime(1985, 10, 25));

            // Displaying details
            Console.WriteLine("Person 1 Details:");
            person1.Display();

            Console.WriteLine("\nPerson 2 Details:");
            person2.Display();

            Console.WriteLine("\nPerson 3 Details:");
            person3.Display();

            // Accepting new details for person2
            person2.AcceptDetails("Jane", "Smith", "jane.newemail@example.com", new DateTime(1992, 7, 20));
            Console.WriteLine("\nUpdated Person 2 Details:");
            person2.Display();
        }
    }
    
}
