/* 
 * Create a program that receives an array and several rotations that you have to perform. The rotations are done by moving the first element of the array from the front to the back. Print the resulting array.
 */

/*
 * 51 47 32 61 21
   2
 */

int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int firstEl = arrayOfNumbers[0];
    for (int j = 0; j < arrayOfNumbers.Length - 1; j++)
    {
        arrayOfNumbers[j] = arrayOfNumbers[j + 1];
    }

    arrayOfNumbers[arrayOfNumbers.Length - 1] = firstEl;
}

Console.WriteLine(string.Join(" ", arrayOfNumbers));