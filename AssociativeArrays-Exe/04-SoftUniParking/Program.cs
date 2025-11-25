namespace _04_SoftUniParking
{
    internal class Program
    {
        public class Parking
        {
            public Parking(string username, string licensePlate)
            {
                Username = username;
                LicenseplateNumber = licensePlate;
            }
            public string Username { get; set; }
            public string LicenseplateNumber { get; set; }

            public override string ToString()
            {
                return $"{Username} => {LicenseplateNumber}";

            }
        }
        static void Main(string[] args)
        {
            int countLicensePlateNumbers = int.Parse(Console.ReadLine());

            Dictionary<string, Parking> registerMap = new();

            for (int i = 0; i < countLicensePlateNumbers; i++)
            {
                string[] commands = Console.ReadLine().Split(" ");

                string action = commands[0];
                string name = commands[1];

                switch (action)
                {
                    case "register":
                        string licensePlateNumber = commands[2];

                        if (!registerMap.ContainsKey(name))
                        {
                            Parking parking = new Parking(name, licensePlateNumber);

                            registerMap.Add(name, parking);
                            Console.WriteLine($"{parking.Username} registered {parking.LicenseplateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }

                        break;
                    case "unregister":

                        if (registerMap.ContainsKey(name))
                        {
                            registerMap.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }

                        break;
                }
            }

            foreach (KeyValuePair<string, Parking> register in registerMap)
            {
                Console.WriteLine($"{register.Value.ToString()}");
            }

        }
    }
}
