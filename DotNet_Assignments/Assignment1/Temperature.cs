using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Temperature
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Fahrenheit");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            double c = ((Fahrenheit - 32) * 5 / 9);
            Console.WriteLine("Temperature in Celsius:"+c);
        }
    }
}
