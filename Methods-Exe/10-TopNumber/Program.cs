namespace _10_TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            for (int i = 8; i <= end; i++)
            {
                if (IsDigitDivisibleByEight(i) && IsOdd(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsDigitDivisibleByEight(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;

                sum += digit;

                number /= 10;
            }

            bool isDivisible = sum % 8 == 0;
            return isDivisible;
        }

        public static bool IsOdd(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 != 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
    }
}
