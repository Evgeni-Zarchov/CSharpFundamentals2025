namespace _07_RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            string result = ReturnString(word, number);

            Console.WriteLine(result);
        }

        static string ReturnString(string word, int number)
        {
            string result = string.Empty;

            for (int i = 0; i < number; i++)
            {
                result += word;
            }

            return result;
        }
    }
}
