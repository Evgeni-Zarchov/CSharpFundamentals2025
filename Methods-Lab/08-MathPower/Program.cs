namespace _08_MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = MathPower(number, power);

            Console.WriteLine(result);
        }

        static double MathPower(double number, double power)
        {
            double result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
