using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
    }

    // Define the IStudentRepository interface
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void RemoveStudent(int id);
        void UpdateStudent(Student student);
    }

    // Implement the IStudentRepository interface in the StudentRepository class
    public class StudentRepository : IStudentRepository
    {
        private List<Student> students = new List<Student>();
        private int nextId = 1;

        public void AddStudent(Student student)
        {
            student.Id = nextId++;
            students.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public void RemoveStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                students.Remove(student);
            }
        }

        public void UpdateStudent(Student student)
        {
            var existingStudent = GetStudentById(student.Id);
            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.Age = student.Age;
                existingStudent.Course = student.Course;
            }
        }
    }

    class Exercise5
    {
        static void Main()
        {
            IStudentRepository studentRepository = new StudentRepository();

            // Add students
            studentRepository.AddStudent(new Student { Name = "Alice", Age = 20, Course = "Math" });
            studentRepository.AddStudent(new Student { Name = "Bob", Age = 22, Course = "Science" });

            // Display all students
            Console.WriteLine("All students:");
            foreach (var student in studentRepository.GetAllStudents())
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Course: {student.Course}");
            }

            // Get student by ID
            var studentById = studentRepository.GetStudentById(1);
            if (studentById != null)
            {
                Console.WriteLine($"\nStudent with ID 1: Name: {studentById.Name}, Age: {studentById.Age}, Course: {studentById.Course}");
            }

            // Update student
            studentRepository.UpdateStudent(new Student { Id = 1, Name = "Alice Smith", Age = 21, Course = "Mathematics" });

            // Display all students after update
            Console.WriteLine("\nAll students after update:");
            foreach (var student in studentRepository.GetAllStudents())
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Course: {student.Course}");
            }

            // Remove student
            studentRepository.RemoveStudent(1);

            // Display all students after removal
            Console.WriteLine("\nAll students after removal:");
            foreach (var student in studentRepository.GetAllStudents())
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Course: {student.Course}");
            }
        }
    }
}
