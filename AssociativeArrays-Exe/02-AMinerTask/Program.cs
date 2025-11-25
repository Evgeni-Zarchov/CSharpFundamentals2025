/*
 Gold
 155
 Gold
 155
 */
namespace _02_AMinerTask
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> resourceMap = new();

            string command;
            while ((command = Console.ReadLine()) != "stop")
            {
                string resource = command;
                int quantity = int.Parse(Console.ReadLine());

                if (!resourceMap.ContainsKey(resource))
                {
                    resourceMap.Add(resource, 0);
                }
                resourceMap[resource] += quantity;
            }

            foreach (var resourceInfo in resourceMap)
            {
                Console.WriteLine($"{resourceInfo.Key} -> {resourceInfo.Value}");
            }
        }
    }
}
