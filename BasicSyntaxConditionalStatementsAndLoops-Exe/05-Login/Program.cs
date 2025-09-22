string input = Console.ReadLine();

string password = string.Empty;

for (int i = input.Length - 1; i >= 0; i--)
{
    password += input[i];
}

int attemps = 1;
string command = Console.ReadLine();

while (true)
{

    if (command == password)
    {
        Console.WriteLine($"User {input} logged in.");
        break;
    }

    if (attemps == 4)
    {
        Console.WriteLine($"User {input} blocked!");
        break;
    }

    if (command != password)
    {
        Console.WriteLine("Incorrect password. Try again.");
    }

    attemps++;
    command = Console.ReadLine();
}
