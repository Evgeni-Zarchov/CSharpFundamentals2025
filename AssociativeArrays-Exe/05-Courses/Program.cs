using System.Net.Http.Headers;

namespace _05_Courses
{
    internal class Program
    {
        class Course
        {
            public Course(string courseInfo)
            {
                CourseInfo = courseInfo;
                Students = new List<string>();
            }

            public string CourseInfo { get; set; }
            public List<string> Students { get; set; }

            public override string ToString()
            {
                string result = string.Empty;

                result += $"{CourseInfo}: {Students.Count}\n";

                for (int i = 0; i < Students.Count; i++)
                {
                    result += $"-- {Students[i]}\n";
                }

                return result.Trim();
            }
        }

        static void Main(string[] args)
        {
            string command;
            Dictionary<string, Course> courseMap = new Dictionary<string, Course>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] action = command.Split(" : ");

                string courseInfo = action[0];
                string studentName = action[1];

                if (!courseMap.ContainsKey(courseInfo))
                {
                    Course course = new Course(courseInfo);
                    courseMap.Add(courseInfo, course);
                }

                courseMap[courseInfo].Students.Add(studentName);
            }

            foreach (var course in courseMap)
            {
                Console.WriteLine(course.Value);
            }
        }
    }
}
