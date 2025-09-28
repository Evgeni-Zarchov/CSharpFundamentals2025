int n = int.Parse(Console.ReadLine());
int capacity = 0;

for (int i = 1; i <= n; i++)
{
    int liters = int.Parse(Console.ReadLine());

    if (capacity + liters <= 255)
    {
        capacity += liters;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }

}

Console.WriteLine(capacity);