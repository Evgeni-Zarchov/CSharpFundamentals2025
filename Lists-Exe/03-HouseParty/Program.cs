namespace _03_HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int i = 1; i <= end; i++)
            {
                string[] names = Console.ReadLine().Split().ToArray();

                string name = names[0];


                if (!guestList.Contains(name) && names.Length == 3)
                {
                    guestList.Add(name);
                }
                else
                {
                    if (guestList.Contains(name) && names.Length == 3)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        if (guestList.Contains(name) && names.Length == 4)
                        {
                            guestList.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} is not in the list!");
                        }

                    }

                }

            }

            Console.WriteLine(string.Join(" " +
                "\n", guestList));
        }
    }
}
