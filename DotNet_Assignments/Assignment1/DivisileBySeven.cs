using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DivisileBySeven
    {
        static void Main(string[] args)
        {
            int n1 = 200;
            int n2 = 300;
            for (int i = n1; i < n2; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
