namespace _01_CountCharsInAString
{
    internal class Program
    {
        static void Main()
        {
            string count = Console.ReadLine();

            Dictionary<char, int> charsMap = new Dictionary<char, int>();

            for (int i = 0; i < count.Length; i++)
            {
                var chars = count[i];

                if (chars != ' ')
                {
                    if (!charsMap.ContainsKey(chars))
                    {
                        charsMap.Add(chars, 0);
                    }
                    charsMap[chars]++;
                }
            }

            foreach (var chars in charsMap)
            {
                Console.WriteLine($"{chars.Key} -> {chars.Value}");
            }
        }
    }
}
