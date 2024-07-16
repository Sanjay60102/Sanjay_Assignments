using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Exercise3
    {
        static void Main(string[] args)
        {
            // Create a SortedDictionary to hold employee codes and names
            SortedDictionary<int, string> employees = new SortedDictionary<int, string>();

            // Adding employees to the dictionary
            employees.Add(103, "Alice Smith");
            employees.Add(101, "John Doe");
            employees.Add(104, "Mary Johnson");
            employees.Add(102, "James Brown");

            // Displaying employees in a sorted manner
            Console.WriteLine("Employee Code\tEmployee Name");
            Console.WriteLine("-------------------------------");
            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"{employee.Key}\t\t{employee.Value}");
            }
        }
    }
}
