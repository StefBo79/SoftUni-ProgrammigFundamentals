using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> register = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" -> ");

            while (input[0] != "End")
            {               
                string companyName = input[0];
                string id = input[1];

                if (!register.ContainsKey(companyName))
                {
                    register.Add(companyName, new List<string>());
                    register[companyName].Add(id);
                    input = Console.ReadLine().Split(" -> ");
                    continue;
                }
                if (!register[companyName].Contains(id))
                {
                    register[companyName].Add(id);
                }
                input = Console.ReadLine().Split(" -> ");

            }
            foreach (var company in register.OrderBy(c => c.Key))
            {
                Console.WriteLine(company.Key);
                Console.Write("-- ");
                Console.WriteLine(string.Join("\n-- ", company.Value));
            }
        }
    }
}
