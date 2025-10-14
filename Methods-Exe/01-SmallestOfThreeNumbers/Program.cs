namespace _01_SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = SmallestNumber(firstNumber, secondNumber);
            result = SmallestNumber(result, thirdNumber);

            Console.WriteLine(result);

        }

        public static int SmallestNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber < secondNumber)
            {
                return firstNumber;
            }
            return secondNumber;
        }

    }
}
