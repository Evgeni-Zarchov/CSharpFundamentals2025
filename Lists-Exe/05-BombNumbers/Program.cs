using System.Numerics;

namespace _05_BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] action = Console.ReadLine().Split();

            int specialNumber = int.Parse(action[0]);
            int detonationPower = int.Parse(action[1]);

            for (int i = 0; i < numbers.Count; i++)
            {


                if (numbers[i] == specialNumber)
                {
                    Target(numbers, detonationPower, i);
                }

            }

            Console.WriteLine(numbers.Sum());
        }

        public static void Target(List<int> numbers, int power, int idx)
        {
            int start = Math.Max(0, idx - power);
            int end = Math.Min(numbers.Count - 1, idx + power);

            for (int i = start; i <= end; i++)
            {
                numbers[i] = 0;
            }
        }
    }
}

