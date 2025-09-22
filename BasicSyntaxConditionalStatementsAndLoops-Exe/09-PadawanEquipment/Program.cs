double budged = double.Parse(Console.ReadLine());
int studentCount = int.Parse(Console.ReadLine());

// Prices.
double priceOfLightSaber = double.Parse(Console.ReadLine());
double priceOfRobes = double.Parse(Console.ReadLine());
double priceOfBelts = double.Parse(Console.ReadLine());

double saberPercent = (double)studentCount * 10 / 100;
double saberCount = studentCount + Math.Ceiling(saberPercent);
double saberTotalPrice = saberCount * priceOfLightSaber;

double robesTotalPrice = studentCount * priceOfRobes;
double beltTotalPrice = studentCount - Math.Floor((double)studentCount / 6);
double beltPrice = priceOfBelts * beltTotalPrice;


double totalPrice = saberTotalPrice + robesTotalPrice + beltPrice;

if (budged >= totalPrice)
{
    Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {Math.Abs(budged - totalPrice):f2}lv more.");
}
