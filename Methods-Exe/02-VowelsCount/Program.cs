
namespace _02_VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int result = CountVowels(text);

            Console.WriteLine(result);
        }

        public static int CountVowels(string text)
        {
            int counter = 0;

            foreach (char word in text)
            {
                if (word == 'a' || word == 'e' || word == 'i' || word == 'o' || word == 'u' || word == 'A' || word == 'E' || word == 'I' || word == 'O' || word == 'U')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
