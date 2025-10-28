using System.Collections.Concurrent;

namespace p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> blackList = Console.ReadLine().Split(", ").ToList();
            string command;
            int counter = 0;
            int blackListCounter = 0;
            int errorCount = 0;
            List<string> secondBlackList = new List<string>();
            while ((command = Console.ReadLine()) != "Report")
            {
                string[] action = command.Split();

                switch (action[0])
                {
                    case "Blacklist":
                        string name = action[1];

                        if (!blackList.Contains(name))
                        {
                            Console.WriteLine($"{name} was not found.");
                        }
                        else
                        {
                            Console.WriteLine($"{name} was blacklisted.");

                            blackList.Remove(name);
                            blackListCounter++;

                        }
                        break;
                    case "Error":
                        int index = int.Parse(action[1]);

                        if (index >= 0 && index <= blackList.Count - 1)
                        {
                           string names = blackList[index];
                            if (blackList.Contains(names))
                            {
                                continue;
                            }
                            else
                            {
                                blackList.RemoveAt(index);
                                Console.WriteLine($"{names} was lost due to an error.");
                                blackList.Insert(index, "Lost");
                                counter++;
                            }
                            
                        }
                        break;
                    case "Change":
                        int nameIndex = int.Parse(action[1]);
                        string newName = action[2];

                        if (nameIndex >= 0 && nameIndex <= blackList.Count - 1)
                        {
                            string currentName = blackList[nameIndex];
                            blackList.RemoveAt(nameIndex);
                            blackList.Insert(nameIndex, newName);
                            Console.WriteLine($"{currentName} changed his username to {newName}.");
                        }
                        break;

                }
            }
            Console.WriteLine($"Blacklisted names: {blackListCounter}");
            Console.WriteLine($"Lost names: {counter}");
            Console.WriteLine($"Blacklisted {string.Join(" ", blackList)}");

        }
    }
}
