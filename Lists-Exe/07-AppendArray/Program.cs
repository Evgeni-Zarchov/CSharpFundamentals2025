using System.Globalization;

namespace _07_AppendArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split("|").Reverse().ToList();
            List<int> numbers = new List<int>();

            foreach (var number in elements)
            {
                numbers.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
