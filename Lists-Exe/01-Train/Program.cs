namespace _01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] action = command.Split();



                if (action[0] == "Add")
                {
                    int wagons = int.Parse(action[1]);
                    train.Add(wagons);
                }
                else
                {
                    int passengers = int.Parse(action[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + passengers <= capacity)
                        {
                            train[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
