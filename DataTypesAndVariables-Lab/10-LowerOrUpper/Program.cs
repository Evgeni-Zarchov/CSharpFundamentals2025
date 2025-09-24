char input = char.Parse(Console.ReadLine());
string output = string.Empty;

if (input >= 65 && input <= 90)
{
    output = "upper-case";
}
else if (input >= 97 && input <= 122)
{
    output = "lower-case";
}

Console.WriteLine(output);
