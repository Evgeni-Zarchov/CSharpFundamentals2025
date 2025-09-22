int startNumber = int.Parse(Console.ReadLine());
int endNumber = int.Parse(Console.ReadLine());

double sumOfNumbers = 0;

for (int i = startNumber; i <= endNumber; i++)
{
    Console.Write($"{i} ");
    sumOfNumbers += i;
}
Console.WriteLine();
Console.WriteLine($"Sum: {sumOfNumbers}");