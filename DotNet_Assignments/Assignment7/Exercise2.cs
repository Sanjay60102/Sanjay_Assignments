using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Exercise2
    {
        static void Main()
        {
            List<string> studentNames = new List<string>();
            int numberOfStudents = 10;

            Console.WriteLine("Enter the names of 10 students:");

            // Accept student names from the user
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write("Enter student name {0}: ", i + 1);
                string name = Console.ReadLine();
                studentNames.Add(name);
            }

            // Sort the student names in descending order
            studentNames.Sort();
            studentNames.Reverse();

            // Display the sorted student names
            Console.WriteLine("\nStudent names in descending order:");
            foreach (string name in studentNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
