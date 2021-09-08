using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%([A-Z]{1}[a-z]{1,})%.*<(\w+)>.*\|([0-9]+)\|.*?([0-9.]+)\$$";
            string input = Console.ReadLine();
            decimal totalPrice = 0;

            while (input != "end of shift")
            {
                Match regex = Regex.Match(input, pattern);

                if (!regex.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var name = regex.Groups[1].Value;
                var product = regex.Groups[2].Value;
                int count = int.Parse(regex.Groups[3].Value);
                decimal price = decimal.Parse(regex.Groups[4].Value);

                decimal sum = count * price;
                Console.WriteLine($"{name}: {product} - {sum:F2}");

                totalPrice += sum;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalPrice:F2}");
        }
    }
}
