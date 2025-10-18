namespace _07_ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool hadChange = false;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] action = command.Split();

                switch (action[0])
                {
                    case "Add":
                        int currentNumber = int.Parse(action[1]);
                        numbers.Add(currentNumber);
                        hadChange = true;
                        break;
                    case "Remove":

                        int numberToRemove = int.Parse(action[1]);
                        numbers.Remove(numberToRemove);
                        hadChange = true;
                        break;
                    case "RemoveAt":

                        int index = int.Parse(action[1]);
                        numbers.RemoveAt(index);
                        hadChange = true;
                        break;
                    case "Insert":

                        int numberToAdd = int.Parse(action[1]);
                        int currentIndex = int.Parse(action[2]);

                        numbers.Insert(currentIndex, numberToAdd);
                        hadChange = true;
                        break;

                    case "Contains":
                        int number = int.Parse(action[1]);

                        if (numbers.Contains(number))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;
                    case "PrintEven":

                        PrintEven(numbers);

                        break;
                    case "PrintOdd":

                        PrintOdd(numbers);

                        break;

                    case "GetSum":
                        int sum = 0;

                        foreach (int num in numbers)
                        {
                            sum += num;
                        }
                        Console.WriteLine(sum);

                        break;

                    case "Filter":
                        int currNum = int.Parse(action[2]);

                        if (action[1] == "<")
                        {

                            foreach (int item in numbers)
                            {
                                if (item < currNum)
                                {
                                    Console.Write($"{item} ");
                                }

                            }

                            Console.WriteLine();
                        }
                        else if (action[1] == ">")
                        {
                            foreach (int item in numbers)
                            {
                                if (item > currNum)
                                {
                                    Console.Write($"{item} ");
                                }

                            }

                            Console.WriteLine();
                        }
                        else if (action[1] == ">=")
                        {
                            foreach (int item in numbers)
                            {
                                if (item >= currNum)
                                {
                                    Console.Write($"{item} ");
                                }

                            }

                            Console.WriteLine();
                        }
                        else if (action[1] == "<=")
                        {
                            foreach (int item in numbers)
                            {
                                if (item <= currNum)
                                {
                                    Console.Write($"{item} ");
                                }

                            }

                            Console.WriteLine();
                        }
                        break;
                }
            }

            if (hadChange)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }

        public static void PrintEven(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }

            Console.WriteLine();
        }

        public static void PrintOdd(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }

            Console.WriteLine();
        }
    }
}
