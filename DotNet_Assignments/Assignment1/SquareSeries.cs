using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class SquareSeries
    {
        static void Main(string[] args)
        {
            int limit = 25;

            Console.WriteLine("Series of perfect squares up to 625:");

            for (int i = 0; i <= limit; i++)
            {
                int square = i * i;
                Console.Write(square);

                // To format output with commas, but not after the last element
                if (i < limit)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
