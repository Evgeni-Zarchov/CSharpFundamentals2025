namespace _04_ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] action = command.Split();

                switch (action[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(action[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(action[1]);
                        int index = int.Parse(action[2]);

                        if (index <= numbers.Count - 1 && index >= 0)
                        {
                            numbers.Insert(index, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        int idx = int.Parse(action[1]);

                        if (idx <= numbers.Count - 1 && idx >= 0)
                        {
                            numbers.RemoveAt(idx);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;
                    case "Shift":
                        int times = int.Parse(action[2]);
                        if (action[1] == "left")
                        {
                            for (int i = 0; i < times; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else if (action[1] == "right")
                        {
                            for (int i = 0; i < times; i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
