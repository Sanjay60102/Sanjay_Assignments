using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Student
    {
        // Data members
        int RollNo;
        string Name;
        string Class;
        int Sem;
        string Branch;
        int[] Marks { get; set; } = new int[5];

        // Constructor
        public Student(int rollNo, string name, string studentClass, int sem, string branch, int[] marks)
        {
            RollNo = rollNo;
            Name = name;
            Class = studentClass;
            Sem = sem;
            Branch = branch;
            Marks = marks;
        }

        // Method to display student data
        public void DisplayData()
        {
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Semester: {Sem}");
            Console.WriteLine($"Branch: {Branch}");
            Console.WriteLine("Marks: " + string.Join(", ", Marks));
        }

        // Method to display result
        public void DisplayResult()
        {
            double average = 0;
            foreach (int mark in Marks)
            {
                if (mark < 35)
                {
                    Console.WriteLine("Result: Failed");
                    return;
                }
                average += mark;
            }
            average /= Marks.Length;

            if (average < 50)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }
    }

    // Main Program
    public class Program
    {
        public static void Main()
        {
            // Reading student details from user input
            Console.Write("Enter Roll No: ");
            int rollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Class: ");
            string studentClass = Console.ReadLine();

            Console.Write("Enter Semester: ");
            int sem = int.Parse(Console.ReadLine());

            Console.Write("Enter Branch: ");
            string branch = Console.ReadLine();

            int[] marks = new int[5];
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Enter marks for subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            // Creating student object with user input
            Student student = new Student(rollNo, name, studentClass, sem, branch, marks);

            // Displaying student data and result
            student.DisplayResult();
            student.DisplayData();
            
        }
    }
}