namespace _02_ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] action = command.Split();

                switch (action[0])
                {

                    case "Delete":
                        int numberToDelete = int.Parse(action[1]);
                        numbers.RemoveAll(el => el == numberToDelete);

                        break;
                    case "Insert":
                        int elementToInsert = int.Parse(action[1]);
                        int index = int.Parse(action[2]);

                        numbers.Insert(index, elementToInsert);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
