int end = int.Parse(Console.ReadLine());

for (int number = 1; number <= end; number++)
{
    int total = 0;
    int digit = number;

    while (number > 0)
    {
        total += number % 10;
        number = number / 10;
    }

    bool isSpecial = (total == 5) || (total == 7) || (total == 11);

    Console.WriteLine("{0} -> {1}", digit, isSpecial);

    total = 0;
    number = digit;
}