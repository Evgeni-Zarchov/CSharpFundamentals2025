namespace _06_VehicleCatalogue
{
    internal class Program
    {
        class Vehicle
        {
            public Vehicle(string type, string model, string color, decimal hp)
            {
                Type = type;
                Model = model;
                Color = color;
                HP = hp;
            }

            private string type;
            public string Type
            {
                get
                {
                    return type;
                }
                set
                {
                    type = CapitalLetter(value);
                }
            }
            public string Model { get; set; }
            public string Color { get; set; }
            public decimal HP { get; set; }

            public override string ToString()
            {
                string result = string.Empty;

                result += $"Type: {CapitalLetter(Type)}\n";
                result += $"Model: {Model}\n";
                result += $"Color: {Color}\n";
                result += $"Horsepower: {HP}";

                return result;
            }

            public string CapitalLetter(string value)
            {
                char[] array = value.ToCharArray();
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }

                return new string(array);
            }
        }


        static void Main(string[] args)
        {

            List<Vehicle> vehicleCatalogue = new List<Vehicle>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] info = command.Split(" ");
                string type = info[0];
                string model = info[1];
                string color = info[2];
                decimal hp = decimal.Parse(info[3]);

                Vehicle vehicle = new Vehicle(type, model, color, hp);

                vehicleCatalogue.Add(vehicle);
            }

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                string typeCar = command;

                Vehicle findCar = vehicleCatalogue.Find(v => v.Model == typeCar);

                if (findCar != null)
                {
                    Console.WriteLine(findCar.ToString());
                }
            }

            decimal averageCarHp = vehicleCatalogue
                .Where(v => v.Type == "Car")
                .Select(v => v.HP)
                .DefaultIfEmpty()
                .Average();

            decimal averageTruckHp = vehicleCatalogue
                .Where(v => v.Type == "Truck")
                .Select(v => v.HP)
                .DefaultIfEmpty()
                .Average();

            Console.WriteLine($"Cars have average horsepower of: {averageCarHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:f2}.");
        }
    }
}
