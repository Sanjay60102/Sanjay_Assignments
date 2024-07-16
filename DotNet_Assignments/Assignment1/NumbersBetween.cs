using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class NumbersBetween
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first value:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second value:");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
