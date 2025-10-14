
namespace _03_CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintChars(firstChar, secondChar);
        }

        public static void PrintChars(char firstChar, char secondChar)
        {
            int startIndex = (char)Math.Min(firstChar, secondChar) + 1;
            int endIndex = (char)Math.Max(firstChar, secondChar);

            for (int i = startIndex; i < endIndex; i++)
            {
                Console.Write($"{(char)i} ");
            }

        }

    }
}
