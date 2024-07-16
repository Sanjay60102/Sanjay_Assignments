using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Building
    {
        string Type;
        string Capacity;
        string Dimension;
        int? FloorNumber;
        string LandDimension;
        string DateOfCompletion;

        // Constructor accepting all values
        public Building(string type, string capacity, string dimension, int? floorNumber, string landDimension, string dateOfCompletion)
        {
            Type = type;
            Capacity = capacity;
            Dimension = dimension;
            FloorNumber = floorNumber;
            LandDimension = landDimension;
            DateOfCompletion = dateOfCompletion;
        }

        // Method to display details
        public void ShowData()
        {
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Dimension: {Dimension}");
            if (Type.ToLower() == "flat" && FloorNumber.HasValue)
            {
                Console.WriteLine($"Floor Number: {FloorNumber}");
            }
            else if (Type.ToLower() == "villa")
            {
                Console.WriteLine($"Land Dimension: {LandDimension}");
            }
            Console.WriteLine($"Date of Completion: {DateOfCompletion}");
        }
        static void Main(string[] args)
        {
            // Creating instances of Building for Flat and Villa
            Building flat = new Building("Flat", "3BHK", "1200 sq ft", 5, null, "2022-08-15");
            Building villa = new Building("Villa", "4BHK", "2500 sq ft", null, "30X40", "2023-05-20");

            // Displaying details of Flat
            Console.WriteLine("Flat Details:");
            flat.ShowData();

            // Displaying details of Villa
            Console.WriteLine("\nVilla Details:");
            villa.ShowData();
        }
    }
}