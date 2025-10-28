namespace _02_TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peoplesQueue = int.Parse(Console.ReadLine());

            int[] lift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int liftCapacity = 4;

            for (int i = 0; i < lift.Length; i++)
            {
                int count = lift[i];
                for (int j = count; j < liftCapacity; j++)
                {
                    lift[i]++;
                    peoplesQueue--;

                    if (peoplesQueue == 0)
                    {
                        if (lift.Sum() < lift.Length * liftCapacity)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }

                        Console.WriteLine(string.Join(" ", lift));
                        return;
                    }
                }
            }

            Console.WriteLine($"There isn't enough space! {peoplesQueue} people in a queue!");

            Console.WriteLine(string.Join(" ", lift));
        }
    }
}
