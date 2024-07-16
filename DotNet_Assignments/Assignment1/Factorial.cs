using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }
    }
}
