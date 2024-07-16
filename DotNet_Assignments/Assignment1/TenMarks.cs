using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TenMarks
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
            int total = marks.Sum();
            // Calculate average
            double average = marks.Average();
            // Find minimum marks
            int minMarks = marks.Min();
            // Find maximum marks
            int maxMarks = marks.Max();

            // Display results
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine("Minimum Marks: " + minMarks);
            Console.WriteLine("Maximum Marks: " + maxMarks);

            // Display marks in ascending order
            int[] ascendingOrder = marks.OrderBy(m => m).ToArray();
            Console.WriteLine("Marks in Ascending Order: " + string.Join(", ", ascendingOrder));

            // Display marks in descending order
            int[] descendingOrder = marks.OrderByDescending(m => m).ToArray();
            Console.WriteLine("Marks in Descending Order: " + string.Join(", ", descendingOrder));
        }
    }
}
