namespace _06_ListManipulationBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] action = command.Split();

                switch (action[0])
                {
                    case "Add":
                        int currentNumber = int.Parse(action[1]);
                        numbers.Add(currentNumber);

                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(action[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int index = int.Parse(action[1]);
                        numbers.RemoveAt(index);
                        break;
                    case "Insert":
                        int numberToAdd = int.Parse(action[1]);
                        int currentIndex = int.Parse(action[2]);

                        numbers.Insert(currentIndex, numberToAdd);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
