namespace _01_GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodQuantity = double.Parse(Console.ReadLine());
            double hayQuantity = double.Parse(Console.ReadLine());
            double coverQuantity = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            foodQuantity *= 1000;
            hayQuantity *= 1000;
            coverQuantity *= 1000;
            weight *= 1000;

            int day = 1;

            while (day <= 30)
            {
                foodQuantity -= 300;

                if (day % 2 == 0)
                {
                    hayQuantity -= foodQuantity * 0.05;
                }

                if (day % 3 == 0)
                {
                    coverQuantity -= weight / 3;
                }

                if (foodQuantity <= 0 || hayQuantity <= 0 || coverQuantity <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");

                    return;
                }

                day++;
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodQuantity / 1000):f2}, Hay: {(hayQuantity / 1000):f2}, Cover: {(coverQuantity / 1000):f2}.");
        }
    }
}
