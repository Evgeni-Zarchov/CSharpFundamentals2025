int lostGameCount = int.Parse(Console.ReadLine());

// Prices.
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

// Logic.

double headsetCount = lostGameCount / 2;
double mouseCount = lostGameCount / 3;
double keyboardCount = lostGameCount / 6;
double displayCount = lostGameCount / 12;

// Output.

double totalPrice = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;

Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
