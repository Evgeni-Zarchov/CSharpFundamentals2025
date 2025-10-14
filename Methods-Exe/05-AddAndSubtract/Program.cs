
namespace _05_AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = AddAndSubtract(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(result);
        }

        private static int AddAndSubtract(int firstNumber, int secondNumber, int thirdNumber)
        {
            return (firstNumber + secondNumber) - thirdNumber;
        }
    }
}
