
int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sumOfNumbers = 0;
bool isIdentical = true;

for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] == secondArray[i])
    {
        sumOfNumbers += firstArray[i];
    }
    else
    {
        isIdentical = false;
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        break;
    }
}

if (isIdentical)
{
    Console.WriteLine($"Arrays are identical. Sum: {sumOfNumbers}");
}
