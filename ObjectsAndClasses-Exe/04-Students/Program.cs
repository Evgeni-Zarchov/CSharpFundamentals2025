using System.Collections.Generic;
using System.Diagnostics;

namespace _04_Students
{
    internal class Program
    {
        class Student
        {
            public Student(string firstName, string lastName, float grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public float Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }


        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentCount; i++)
            {
                string[] info = Console.ReadLine().Split();

                string firstName = info[0];
                string lastName = info[1];
                float grade = float.Parse(info[2]);

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);
            }

            List<Student> sortedByGradeStudents = students.OrderByDescending(s => s.Grade).ToList();

            foreach (Student student in sortedByGradeStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
