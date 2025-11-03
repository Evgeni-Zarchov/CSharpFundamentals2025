
namespace _05_StudentsV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] info = command.Split();

                string firstName = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string homeTown = info[3];


                Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                if (student == null)
                {
                    students.Add(new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
            }

            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
