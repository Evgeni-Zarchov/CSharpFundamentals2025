namespace p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double pricePerEgg = double.Parse(Console.ReadLine());
            double pricePerApron = double.Parse(Console.ReadLine());

            double eggPrice = pricePerEgg * 10 * students;
            double finalApron = pricePerApron * 1 * students;
            finalApron *= 1.2;
            double flourCount = flourPrice * students;

            //if (flourCount % 5 == 0)
            //{
            //    flourCount -= 1;
            //}

            double totalPrice = eggPrice + finalApron + flourCount;
            double finalPrice = Math.Abs(totalPrice - budged);

            if (totalPrice <= budged)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$");
            }
            else
            {
                Console.WriteLine($"{finalPrice:f2}$ more needed.");
            }
        }
    }
}
