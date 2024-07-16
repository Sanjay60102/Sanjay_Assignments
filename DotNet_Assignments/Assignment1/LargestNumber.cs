using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class LargestNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter fisrt number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Fisrt number is largest");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("Second number is largest");
            }
            else
            {
                Console.WriteLine("Third number is largest");
            }
        }
    }
}
