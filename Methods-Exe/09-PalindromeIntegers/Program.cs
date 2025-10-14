namespace _09_PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbersAsString;

            while ((numbersAsString = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(numbersAsString).ToString().ToLower());
            }
        }

        public static bool IsPalindrome(string input)
        {
            string reversedNumber = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedNumber += input[i];
            }

            return reversedNumber == input;
        }
    }
}
