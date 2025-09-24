double length, width, height = 0;

length = double.Parse(Console.ReadLine());
width = double.Parse(Console.ReadLine());
height = double.Parse(Console.ReadLine());

double volume = (length * width * height) / 3;

Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");