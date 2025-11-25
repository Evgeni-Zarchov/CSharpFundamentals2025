namespace _06_StudentAcademy
{
    internal class Program
    {
        class Academy
        {
            public Academy(string studentName)
            {
                StudentName = studentName;
                Grades = new List<decimal>();
            }
            public List<decimal> Grades { get; set; }
            public string StudentName { get; set; }


            public override string ToString()
            {
                string result = string.Empty;
                result += $"{StudentName} -> {Grades.Average():f2}";
                return result;
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Academy> academyMap = new();

            int studentCount = int.Parse(Console.ReadLine());
            decimal grade;
            string students;

            for (int i = 0; i < studentCount; i++)
            {

                students = Console.ReadLine();
                grade = decimal.Parse(Console.ReadLine());

                if (!academyMap.ContainsKey(students))
                {
                    Academy academy = new Academy(students);

                    academyMap.Add(students, academy);
                }

                academyMap[students].Grades.Add(grade);
            }

            var sortedStudentsInAcademy = academyMap.Where(s => s.Value.Grades.Average() >= 4.50m);

            foreach (var student in sortedStudentsInAcademy)
            {
                Console.WriteLine($"{student.Value}");
            }

        }
    }
}
