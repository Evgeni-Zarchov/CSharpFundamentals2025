namespace _04_ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new();

            for (int i = 0; i < n; i++)
            {
                string currentProdcuts = Console.ReadLine();

                products.Add(currentProdcuts);
            }
            products.Sort();

            int counter = 0;
            foreach (string product in products)
            {
                counter++;
                Console.WriteLine($"{counter}.{product}");
            }
        }
    }
}
