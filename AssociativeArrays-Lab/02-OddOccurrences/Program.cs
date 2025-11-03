namespace _02_OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            Dictionary<string, int> counts = new();

            foreach (string word in words)
            {
                string wordToLower = word.ToLower();

                if (!counts.ContainsKey(wordToLower))
                {
                    counts.Add(wordToLower, 1);
                }
                else
                {
                    counts[wordToLower]++;
                }
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write($"{count.Key} ");
                }
            }
        }
    }
}
