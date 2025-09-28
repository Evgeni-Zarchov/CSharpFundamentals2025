using System.Numerics;

int number = int.Parse(Console.ReadLine());

BigInteger bestSnowball = 0;

int snowballValue = 0;
int snowballBestTime = 0;
int snowballBestQuality = 0;

for (int i = 1; i <= number; i++)
{
    int snowball = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    BigInteger currentSnowball = BigInteger.Pow(snowball / snowballTime, snowballQuality);

    if (currentSnowball >= bestSnowball)
    {
        bestSnowball = currentSnowball;
        snowballBestTime = snowballTime;
        snowballBestQuality = snowballQuality;
        snowballValue = snowball;
    }
}

Console.WriteLine($"{snowballValue} : {snowballBestTime} = {bestSnowball} ({snowballBestQuality})");