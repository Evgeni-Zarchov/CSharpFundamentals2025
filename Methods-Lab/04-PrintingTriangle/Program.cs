namespace _04_PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            for (int i = 1; i < end; i++)
            {
                PrintLine(1, i);
            }

            for (int i = end; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
