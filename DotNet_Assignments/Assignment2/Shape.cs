using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Shapes
    {
        // Method to calculate the area of a rectangle
        public double Area(double length, double width)
        {
            return length * width;
        }

        // Method to calculate the area of a triangle
        public double Area(double @base, double height, bool isTriangle)
        {
            if (isTriangle)
            {
                return 0.5 * @base * height;
            }
            else
            {
                throw new ArgumentException("Invalid parameters for triangle area calculation.");
            }
        }

        // Method to calculate the area of a circle
        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Method to calculate the area of a square
        public double Area(int side)
        {
            return side * side;
        }
    }

    // Main Program
    public class Shape
    {
        public static void Main()
        {
            Shapes shapes = new Shapes();

            // Calculating and displaying the area of a rectangle
            double rectangleLength = 10;
            double rectangleWidth = 5;
            Console.WriteLine($"Area of Rectangle: {shapes.Area(rectangleLength, rectangleWidth)}");

            // Calculating and displaying the area of a triangle
            double triangleBase = 8;
            double triangleHeight = 5;
            Console.WriteLine($"Area of Triangle: {shapes.Area(triangleBase, triangleHeight, true)}");

            // Calculating and displaying the area of a circle
            double circleRadius = 7;
            Console.WriteLine($"Area of Circle: {shapes.Area(circleRadius)}");

            // Calculating and displaying the area of a square
            int squareSide = 4;
            Console.WriteLine($"Area of Square: {shapes.Area(squareSide)}");
        }
    }
}
