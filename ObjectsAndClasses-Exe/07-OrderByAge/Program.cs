namespace _07_OrderByAge
{
    internal class Program
    {
        class Person
        {
            public Person(string name, string id, int age)
            {
                Name = name;
                ID = id;
                Age = age;
            }

            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                string result = string.Empty;
                result += $"{Name} with ID: {ID} is {Age} years old.";
                return result;
            }
        }
        static void Main(string[] args)
        {
            string command;

            List<Person> persons = new List<Person>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] personInfo = command.Split(" "); // George 123456 20

                // Person Info...

                string name = personInfo[0];
                string id = personInfo[1];
                int age = int.Parse(personInfo[2]);

                Person person = new Person(name, id, age);

                persons.Add(person);
            }

            var sortedPersons = persons.OrderBy(p => p.Age);

            foreach (Person person in sortedPersons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
