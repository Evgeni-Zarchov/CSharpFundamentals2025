namespace _04_Students
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
                string town = info[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = town;

                students.Add(student);
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
