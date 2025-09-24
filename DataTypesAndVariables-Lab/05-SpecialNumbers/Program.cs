int end = int.Parse(Console.ReadLine());

for (int i = 1; i <= end; i++)
{
    int digit = i;
    int sum = 0;

    while (digit != 0)
    {
        sum += digit % 10;
        digit /= 10;
    }

    bool isSpecial = sum == 5 || sum == 7 || sum == 11;

    if (isSpecial)
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
}
