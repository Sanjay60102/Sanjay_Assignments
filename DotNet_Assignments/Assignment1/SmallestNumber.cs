using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class SmallestNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int number3 = int.Parse(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            int number4 = int.Parse(Console.ReadLine());

            Console.Write("Enter the fifth number: ");
            int number5 = int.Parse(Console.ReadLine());

            // Determine the smallest number
            int smallest = number1;

            if (number2 < smallest)
            {
                smallest = number2;
            }

            if (number3 < smallest)
            {
                smallest = number3;
            }

            if (number4 < smallest)
            {
                smallest = number4;
            }

            if (number5 < smallest)
            {
                smallest = number5;
            }

            // Display the smallest number
            Console.WriteLine("The smallest number is: " + smallest);

        }
    }
}
