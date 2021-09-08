using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            //               @"\>*(?<furniture>\w+)\<*(?<price>[0-9.]+|[0-9]+)!(?<quantity>\d+)"
            string pattern = @"\>*(?<furniture>\w+)\<*(?<price>[0-9.]+|[0-9]+)!(?<quantity>\d+)";
            List<string> orders = new List<string>();
            double sum = 0;

            string input = Console.ReadLine();

            while (input != "Purchase")
            {
                orders.Add(input);
                input = Console.ReadLine();
            }

            MatchCollection matchedOrders = Regex.Matches(string.Join(" ", orders), pattern);
            Console.WriteLine("Bought furniture:");

            foreach (Match orderID in matchedOrders)
            {
                double price = double.Parse(orderID.Groups["price"].Value);
                int qty = int.Parse(orderID.Groups["quantity"].Value);
                string furnture = orderID.Groups["furniture"].Value;
                sum += price * qty;
                Console.WriteLine(furnture);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
