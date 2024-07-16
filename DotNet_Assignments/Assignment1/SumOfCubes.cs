using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class SumOfCubes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= num; i++)
            {
                int cube = i * i * i;
                result += cube;
            }
            Console.WriteLine(result);
        }
    }
}
