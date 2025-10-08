/*
 * Create a program to find all the top integers in an array. A top integer is an integer that is greater than all the elements to its right.
 */


int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    bool isTop = true;

    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] <= numbers[j])
        {
            isTop = false;
            break;
        }
    }

    if (isTop)
    {
        Console.Write($"{numbers[i]} ");
    }

}

