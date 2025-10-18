namespace _03_MergingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> listOfNumbers = new();

            int count = firstNumbers.Count > secondNumbers.Count ? firstNumbers.Count : secondNumbers.Count;

            for (int i = 0; i < count; i++)
            {
                if (firstNumbers.Count > i)
                {
                    listOfNumbers.Add(firstNumbers[i]);
                }

                if (secondNumbers.Count > i)
                {
                    listOfNumbers.Add(secondNumbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
