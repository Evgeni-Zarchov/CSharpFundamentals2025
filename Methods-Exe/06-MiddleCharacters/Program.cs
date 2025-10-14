namespace _06_MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintChars(text);
        }

        public static void PrintChars(string text)
        {
            int midElement = text.Length / 2;
            string result = $"{text[midElement]}";

            if (text.Length % 2 == 0)
            {
                result = $"{text[midElement - 1]}" + result;
            }

            Console.WriteLine(result);
        }
    }
}
