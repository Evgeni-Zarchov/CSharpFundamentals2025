/*
 * Create a program that creates 2 arrays. You will be given an integer n. On the next n lines, you will get 2 integers. Form 2 new arrays in a zig-zag pattern
 */

/*
 * Input.
 * 4
  1 5
  9 10
  31 81
  41 20
*/

/*
 *  To form zig-zag pattern i have to play with the index.
 *  [1,10,31.20] - Even index.
 *  [5,9,81,41] - Odd index.
 */

int size = int.Parse(Console.ReadLine());

int[] firstArray = new int[size];
int[] secondArray = new int[size];

for (int i = 1; i <= size; i++)
{
    int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    int firstNum = numbers[0];
    int secondNum = numbers[1];

    if (i % 2 == 0)
    {
        firstArray[i - 1] = firstNum;
        secondArray[i - 1] = secondNum;
    }
    else
    {
        firstArray[i - 1] = secondNum;
        secondArray[i - 1] = firstNum;
    }
}
Console.WriteLine(string.Join(" ", secondArray));
Console.WriteLine(string.Join(" ", firstArray));