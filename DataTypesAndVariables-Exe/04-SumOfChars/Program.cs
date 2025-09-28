
int number = int.Parse(Console.ReadLine());
int sumOfChars = 0;

for (int i = 1; i <= number; i++)
{
    char chars = char.Parse(Console.ReadLine());
    sumOfChars += chars;
}

Console.WriteLine($"The sum equals: {sumOfChars}");