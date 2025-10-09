namespace _09_GreaterOfTwoValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":

                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine(GetMax(firstNumber, secondNumber));

                    break;
                case "char":

                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());

                    Console.WriteLine(GetMax(firstChar, secondChar));

                    break;
                case "string":

                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();

                    Console.WriteLine(GetMax(firstString, secondString));

                    break;
            }
        }

        static int GetMax(int firstNumber, int SecondNumber)
        {
            if (firstNumber > SecondNumber)
            {
                return firstNumber;
            }
            return SecondNumber;
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            return secondChar;
        }

        static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) == 1)
            {
                return firstString;
            }
            return secondString;
        }
    }
}
