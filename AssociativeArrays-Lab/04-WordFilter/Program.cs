namespace _04_WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine()
                .Split(" ")
                .Where(l => l.Length % 2 == 0)
                .ToArray();

            foreach (string letter in letters)
            {
                Console.WriteLine($"{letter} ");
            }
        }
    }
}
