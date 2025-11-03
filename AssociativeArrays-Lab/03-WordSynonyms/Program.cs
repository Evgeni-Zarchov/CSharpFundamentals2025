namespace _03_WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words = new();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();

                if (words.ContainsKey(word) == false)
                {
                    words.Add(word, new List<String>());
                }
                words[word].Add(synonyms);
            }

            foreach ((string key, List<string> value) in words)
            {
                Console.WriteLine($"{key} - {string.Join(", ", value)}");
            }
        }
    }
}
