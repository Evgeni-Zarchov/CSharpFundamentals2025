int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


for (int i = 0; i < numbers.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;

    if (numbers.Length == 1)
    {
        Console.WriteLine("0");
        return;
    }


    for (int left = i; left > 0; left--)
    {
        int leftPosition = left - 1;

        if (left > 0)
        {
            leftSum += numbers[leftPosition];
        }
    }

    for (int right = i; right < numbers.Length; right++)
    {
        int rightPosition = right + 1;

        if (right < numbers.Length - 1)
        {
            rightSum += numbers[rightPosition];
        }
    }

    if (rightSum == leftSum)
    {
        Console.WriteLine(i);
        return;
    }

}

Console.WriteLine("no");


