using System.Data;

namespace _03_Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            Calculator(command, firstNumber, secondNumber);
        }

        static void Calculator(string command, double firstNumber, double secondNumber)
        {
            double result = 0;

            switch (command)
            {
                case "add":
                    result = firstNumber + secondNumber;
                    break;
                case "multiply":
                    result = firstNumber * secondNumber;
                    break;
                case "subtract":
                    result = firstNumber - secondNumber;
                    break;
                case "divide":
                    result = firstNumber / secondNumber;
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
