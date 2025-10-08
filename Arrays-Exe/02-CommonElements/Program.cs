/*
 Create a program that prints out all common elements in two arrays. You have to compare the elements of the second array to the elements of the first.
*/

/*
 * Input
 Hey hello 2 4
 10 hey 4 hello
 */

// Creating the colletions.
string[] firstElements = Console.ReadLine().Split();
string[] secondElements = Console.ReadLine().Split();

string elements = string.Empty;
// Nested for-loops to compare first element all the way to first.
for (int i = 0; i < secondElements.Length; i++)
{
    for (int j = 0; j < firstElements.Length; j++)
    {
        if (secondElements[i] == firstElements[j])
        {
            elements = $"{elements += secondElements[i]} ";
        }
    }
}

// Output.
Console.WriteLine($"{elements}");
