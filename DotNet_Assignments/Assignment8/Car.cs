using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class CarDetails
    {
        public string Model { get; set; }
        public int YearOfMaking { get; set; }

        public CarDetails(string model, int yearOfModel)
        {
            Model = model;
            YearOfMaking = yearOfModel;
        }
        public override string ToString()
        {
            return $"Model:{Model}, Year of Making:{YearOfMaking}";
        }
    }
    internal class Car
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Car Model");
            string model = Console.ReadLine();

            Console.WriteLine("Enter year of making");
            int yearofMaking = int.Parse(Console.ReadLine());

            string path = "D:/CarDetails1.txt";

            CarDetails obj = new CarDetails(model, yearofMaking);

            
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(obj.ToString());
                }
                Console.WriteLine("Car details saved successfully.");
            

        }
    }
}
