namespace _11_MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            double result = Calculate(firstNumber, operation, secondNumber);

            Console.WriteLine(result);
        }

        static double Calculate(double firstNumber, string @operation, double secondNumber)
        {
            double sum = 0;

            switch (@operation)
            {
                case "/":
                    sum = firstNumber / secondNumber;
                    break;
                case "*":
                    sum = secondNumber * firstNumber;
                    break;
                case "+":
                    sum = firstNumber + secondNumber;
                    break;
                case "-":
                    sum = firstNumber - secondNumber;
                    break;
            }

            return sum;
        }
    }
}
