using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TotalEvenAndOddValues
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter array elements");
            for(int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Even = 0;
            int Odd = 0;
            foreach (int k in arr)
            {
                if(k%2 == 0)
                {
                    Even = Even + 1;
                }
                else
                {
                    Odd = Odd + 1;
                }
            }
            Console.WriteLine("Even count:"+ Even);
            Console.WriteLine("Odd count:" + Odd);
        }
    }
}
