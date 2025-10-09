namespace _01_SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintPositiveOrNegative(int.Parse(Console.ReadLine()));
        }

        static void PrintPositiveOrNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
