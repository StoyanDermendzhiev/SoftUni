using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (command != "End")
            {
                string[] input = command.Split(" -> ");
                string companyName = input[0];
                string employeeId = input[1];

                if (companies.ContainsKey(companyName))
                {
                    if (!companies[companyName].Contains(employeeId))
                    {
                        companies[companyName].Add(employeeId);
                    }
                }
                else
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employeeId);
                }

                command = Console.ReadLine();
            }

            companies = companies.OrderBy(x => x.Key)
                                 .ToDictionary(x => x.Key, x => x.Value);

            foreach (var currentCompany in companies)
            {
                Console.WriteLine(currentCompany.Key);

                foreach (string currentEmployee in currentCompany.Value)
                {
                    Console.WriteLine($"-- {currentEmployee}");
                }
            }
        }
    }
}
