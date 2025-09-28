int power = int.Parse(Console.ReadLine());
int targets = int.Parse(Console.ReadLine());
int factor = int.Parse(Console.ReadLine());

int targetCount = 0;
double exhaustedPower = power / 2.0;

while (power >= targets)
{
    power -= targets;
    targetCount++;

    if (power == exhaustedPower && factor != 0)
    {
        power /= factor;
    }
}

Console.WriteLine(power);
Console.WriteLine(targetCount);
