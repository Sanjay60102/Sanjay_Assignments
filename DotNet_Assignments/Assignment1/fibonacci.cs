using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class fibonacci
    {
        static void Main(string[] args)
        {
            int limit = 40;

            int a = 0; 
            int b = 1;
            Console.WriteLine("Fibonacci series up to " + limit + ":");
            Console.Write(a);
            while (b <= limit)
            {
                Console.Write(", " + b);
                int next = a + b;
                a = b;
                b = next;
            }
        }
    }
}
