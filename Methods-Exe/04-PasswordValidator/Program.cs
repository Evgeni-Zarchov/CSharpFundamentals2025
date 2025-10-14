namespace _04_PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isPasswordValid = true;

            if (!IsBetweenSixAndTenChars(password))
            {
                isPasswordValid = false;

                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!IsLettersAndDigits(password))
            {

                isPasswordValid = false;

                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!IsMoreThanTwoDigit(password))
            {
                isPasswordValid = false;

                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        public static bool IsBetweenSixAndTenChars(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        public static bool IsLettersAndDigits(string password)
        {
            return password.All(char.IsLetterOrDigit);
        }

        public static bool IsMoreThanTwoDigit(string password)
        {
            return password.Count(char.IsDigit) >= 2;
        }
    }
}
