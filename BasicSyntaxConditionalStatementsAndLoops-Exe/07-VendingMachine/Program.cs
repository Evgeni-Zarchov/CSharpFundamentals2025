// Coins accumulate to balance.

string command = Console.ReadLine();
double balance = 0;

while (command != "Start")
{
    double coins = double.Parse(command);

    if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1.0 || coins == 2.0)
    {
        balance += coins;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coins}");
    }

    command = Console.ReadLine();
}

// price data base.

double nutsPrice = 2.0;
double waterPrice = 0.70;
double crispsPrice = 1.50;
double sodaPrice = 0.80;
double cokePrice = 1.0;

string action = Console.ReadLine();

// Basic logic to buy.

while (action != "End")
{
    string products = action;

    switch (products)
    {
        case "Nuts":

            if (balance >= nutsPrice)
            {
                Console.WriteLine($"Purchased {products.ToLower()}");
                balance -= nutsPrice;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }

            break;
        case "Water":

            if (balance >= waterPrice)
            {
                Console.WriteLine($"Purchased {products.ToLower()}");
                balance -= waterPrice;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }

            break;
        case "Crisps":

            if (balance >= crispsPrice)
            {
                Console.WriteLine($"Purchased {products.ToLower()}");
                balance -= crispsPrice;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }

            break;
        case "Soda":

            if (balance >= sodaPrice)
            {
                Console.WriteLine($"Purchased {products.ToLower()}");
                balance -= sodaPrice;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }

            break;
        case "Coke":

            if (balance >= cokePrice)
            {
                Console.WriteLine($"Purchased {products.ToLower()}");
                balance -= cokePrice;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }

            break;
        default:

            Console.WriteLine("Invalid product");

            break;
    }

    action = Console.ReadLine();
}

// Money left.

Console.WriteLine($"Change: {balance:f2}");