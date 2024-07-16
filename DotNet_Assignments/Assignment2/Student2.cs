using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    

    public class Student2
    {
        // Data members
        public int RollNo { get; set; }
        public string StudName { get; set; }
        public int MarksInEng { get; set; }
        public int MarksInMaths { get; set; }
        public int MarksInScience { get; set; }

        // Constructor to initialize student details
        public Student2(int rollNo, string studName, int marksInEng, int marksInMaths, int marksInScience)
        {
            RollNo = rollNo;
            StudName = studName;
            MarksInEng = marksInEng;
            MarksInMaths = marksInMaths;
            MarksInScience = marksInScience;
        }

        // Method to calculate total marks
        public int TotalMarks()
        {
            return MarksInEng + MarksInMaths + MarksInScience;
        }

        // Method to calculate percentage
        public double Percentage()
        {
            return TotalMarks() / 3.0;
        }

        // Method to display student details, total marks, and percentage
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Student Name: {StudName}");
            Console.WriteLine($"Marks in English: {MarksInEng}");
            Console.WriteLine($"Marks in Maths: {MarksInMaths}");
            Console.WriteLine($"Marks in Science: {MarksInScience}");
            Console.WriteLine($"Total Marks: {TotalMarks()}");
            Console.WriteLine($"Percentage: {Percentage():F2}%");
        }
    }

    // Main Program
    public class Programs
    {
        public static void Main()
        {
            // Reading student details from user input
            Console.Write("Enter Roll No: ");
            int rollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string studName = Console.ReadLine();

            Console.Write("Enter Marks in English: ");
            int marksInEng = int.Parse(Console.ReadLine());

            Console.Write("Enter Marks in Maths: ");
            int marksInMaths = int.Parse(Console.ReadLine());

            Console.Write("Enter Marks in Science: ");
            int marksInScience = int.Parse(Console.ReadLine());

            // Creating student object with user input
            Student2 student = new Student2(rollNo, studName, marksInEng, marksInMaths, marksInScience);

            // Displaying student details, total marks, and percentage
            student.DisplayStudentDetails();
        }
    }

}
