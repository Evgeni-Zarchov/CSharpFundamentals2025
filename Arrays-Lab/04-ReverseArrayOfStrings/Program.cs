string[] elements = Console.ReadLine().Split(" ");

for (int i = 0; i < elements.Length / 2; i++)
{
    string firstElements = elements[i];
    elements[i] = elements[elements.Length - 1 - i];
    elements[elements.Length - 1 - i] = firstElements;
}

Console.WriteLine(string.Join(" ", elements));