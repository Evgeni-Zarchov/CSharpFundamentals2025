namespace _03_Orders
{
    internal class Program
    {
        class Orders
        {
            public Orders(string productName, decimal price, int quantity)
            {
                ProductName = productName;
                Price = price;
                Quantity = quantity;
            }

            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

        }
        static void Main(string[] args)
        {

            Dictionary<string, Orders> ordersMap = new();

            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] arguments = command.Split(" "); // Name,price,quantity

                string name = arguments[0];
                decimal price = decimal.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);

                if (!ordersMap.ContainsKey(name))
                {
                    Orders order = new Orders(name, 0, 0);
                    ordersMap.Add(name, order);
                }

                ordersMap[name].Price = price;
                ordersMap[name].Quantity += quantity;

            }

            foreach (var orders in ordersMap.Values)
            {
                decimal price = orders.Price * orders.Quantity;

                Console.WriteLine($"{orders.ProductName} -> {price:f2}");
            }
        }
    }
}
