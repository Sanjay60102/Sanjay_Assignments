using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{num}*{i}={num*i}");
            }
        }
    }
}
