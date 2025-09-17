int number = int.Parse(Console.ReadLine());

int sumOfOddNumbers = 0;

for (int i = 1; i <= number; i++)
{
    Console.WriteLine((i * 2) - 1);

    sumOfOddNumbers += ((i * 2) - 1);
}

Console.WriteLine($"Sum: {sumOfOddNumbers}");