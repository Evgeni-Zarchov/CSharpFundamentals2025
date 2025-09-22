int countOfPeople = int.Parse(Console.ReadLine());
string typeOfGroup = Console.ReadLine();
string dayOfWeek = Console.ReadLine();

double pricePerPerson = 0;

if (dayOfWeek == "Friday")
{
    if (typeOfGroup == "Students")
    {
        pricePerPerson = 8.45;
    }
    else if (typeOfGroup == "Business")
    {
        pricePerPerson = 10.90;
    }
    else if (typeOfGroup == "Regular")
    {
        pricePerPerson = 15;
    }
}
else if (dayOfWeek == "Saturday")
{
    if (typeOfGroup == "Students")
    {
        pricePerPerson = 9.80;
    }
    else if (typeOfGroup == "Business")
    {
        pricePerPerson = 15.60;
    }
    else if (typeOfGroup == "Regular")
    {
        pricePerPerson = 20;
    }
}
else if (dayOfWeek == "Sunday")
{
    if (typeOfGroup == "Students")
    {
        pricePerPerson = 10.46;
    }
    else if (typeOfGroup == "Business")
    {
        pricePerPerson = 16;
    }
    else if (typeOfGroup == "Regular")
    {
        pricePerPerson = 22.50;
    }
}

double totalPrice = pricePerPerson * countOfPeople;

if (typeOfGroup == "Students" && countOfPeople >= 30)
{
    totalPrice *= 0.85;
}
else if (typeOfGroup == "Business" && countOfPeople >= 100)
{
    countOfPeople -= 10;
    totalPrice = pricePerPerson * countOfPeople;
}
else if (typeOfGroup == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
{
    totalPrice *= 0.95;
}

Console.WriteLine($"Total price: {totalPrice:f2}");