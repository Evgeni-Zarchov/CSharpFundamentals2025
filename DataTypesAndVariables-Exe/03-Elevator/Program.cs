int numberOfPeoples = int.Parse(Console.ReadLine());
int elevatorCapacity = int.Parse(Console.ReadLine());

int courses = (int)Math.Ceiling((double)numberOfPeoples / elevatorCapacity);

Console.WriteLine(courses);