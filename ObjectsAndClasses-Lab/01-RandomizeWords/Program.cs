namespace _01_RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int i = 0; i < elements.Length; i++)
            {
                int randomIndex = rnd.Next(0, elements.Length);

                Swap(i, randomIndex, elements);
            }

            foreach (string element in elements)
            {
                Console.WriteLine(element);
            }
        }

        public static void Swap(int firstIndex, int secondIndex, string[] words)
        {
            string temp = words[firstIndex];
            words[firstIndex] = words[secondIndex];
            words[secondIndex] = temp;
        }
    }
}
