namespace _07_CompanyUsers
{
    internal class Program
    {
        class Company
        {
            public Company(string companyName)
            {
                CompanyName = companyName;
                EmployeeId = new List<string>();
            }
            public string CompanyName { get; set; }
            public List<string> EmployeeId { get; set; }

            public override string ToString()
            {
                string result = string.Empty;
                result += $"{CompanyName}\n";

                for (int i = 0; i < EmployeeId.Count; i++)
                {
                    result += $"-- {EmployeeId[i]}\n";
                }

                return result.Trim();
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Company> companyMap = new();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] info = command.Split(" -> ");

                string companyName = info[0];
                string employeeId = info[1];

                if (!companyMap.ContainsKey(companyName))
                {
                    Company company = new Company(companyName);

                    companyMap.Add(companyName, company);
                }

                if (!companyMap[companyName].EmployeeId.Contains(employeeId))
                {
                    companyMap[companyName].EmployeeId.Add(employeeId);
                }

            }

            foreach (var company in companyMap)
            {
                Console.WriteLine($"{company.Value}");
            }
        }
    }
}
