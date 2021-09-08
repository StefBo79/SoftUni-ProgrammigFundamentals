using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                
                if (!resources.ContainsKey(input))
                {
                    resources.Add(input, quantity);
                }
                else
                {
                    resources[input] += quantity;
                }

                input = Console.ReadLine();
            }
            foreach (var (key, value) in resources)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
