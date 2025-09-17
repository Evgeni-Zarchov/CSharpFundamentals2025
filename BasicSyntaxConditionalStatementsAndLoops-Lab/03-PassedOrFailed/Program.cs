double grade = double.Parse(Console.ReadLine());
string output = string.Empty;
if (grade >= 3.00)
{
    output = "Passed!";
}
else
{
    output = "Failed!";
}

Console.WriteLine(output);