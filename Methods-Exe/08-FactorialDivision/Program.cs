namespace _08_FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double firstFactoriel = CalculateFactoriel(firstNumber);
            double secondFactoriel = CalculateFactoriel(secondNumber);

            Console.WriteLine($"{firstFactoriel / secondFactoriel:f2}");
        }

        private static double CalculateFactoriel(int n)
        {
            double result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
