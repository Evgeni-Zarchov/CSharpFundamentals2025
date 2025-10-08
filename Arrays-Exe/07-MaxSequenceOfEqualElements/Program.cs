string[] elements = Console.ReadLine().Split();
int bestCount = 0;
string equalElements = string.Empty;

for (int i = 0; i < elements.Length; i++)
{
    int count = 0;

    for (int j = i; j < elements.Length; j++)
    {
        if (elements[i] == elements[j])
        {
            count++;

            if (bestCount < count)
            {
                bestCount = count;
                equalElements = elements[i];
            }

        }
        else
        {
            break;
        }
    }
}

for (int i = 0; i < bestCount; i++)
{
    Console.Write($"{equalElements} ");
}