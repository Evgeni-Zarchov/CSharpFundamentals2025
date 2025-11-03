namespace _01_CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> countNumbers = new();

            double[] numbers = Console.ReadLine().Split().Select(d => double.Parse(d)).ToArray();

            foreach (double number in numbers)
            {
                if (!countNumbers.ContainsKey(number))
                {
                    countNumbers.Add(number, 1);
                }
                else
                {
                    countNumbers[number]++;
                }
            }

            foreach ((double key, int value) in countNumbers)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
