using System.Numerics;

int number = int.Parse(Console.ReadLine());

string bestKeg = string.Empty;

BigInteger biggestKeg = 0;

for (int i = 1; i <= number; i++)
{
    string kegType = Console.ReadLine();
    float radius = float.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    BigInteger currentKeg = (BigInteger)Math.PI * (BigInteger)Math.Pow(radius, 2) * height;

    if (biggestKeg <= currentKeg)
    {
        biggestKeg = currentKeg;
        bestKeg = kegType;
    }
}

Console.WriteLine($"{bestKeg}");
