/*
52 74 23 44 96 110
Shoot 5 10
Shoot 1 80
Strike 2 1
Add 22 3
End

1 2 3 4 5
Strike 0 1
End
*/
namespace _03_MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] action = command.Split();
                int index = int.Parse(action[1]);
                switch (action[0])
                {
                    case "Shoot":
                        int power = int.Parse(action[2]);
                        Shoot(index, power, targets);
                        break;
                    case "Add":
                        int value = int.Parse(action[2]);
                        Add(index, value, targets);
                        break;
                    case "Strike":
                        int radius = int.Parse(action[2]);
                        Strike(index, radius, targets);
                        break;
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }
        public static void Shoot(int index, int power, List<int> targets)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets[index] -= power;

                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }
        }

        public static void Add(int index, int value, List<int> targets)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets.Add(value);
            }

            Console.WriteLine("Invalid placement!");
            return;
        }
        public static void Strike(int index, int radius, List<int> targets)
        {
            if (index < 0 && index > targets.Count - 1)
            {
                Console.WriteLine("Strike missed!");
                return;

            }

            targets.RemoveRange(index - radius, radius * 2 + 1);
        }
    }
}
