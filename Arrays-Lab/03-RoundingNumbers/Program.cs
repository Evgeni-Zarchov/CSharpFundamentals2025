double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

int[] nums = new int[numbers.Length];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
}

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"{numbers[i]} => {nums[i]}");
}