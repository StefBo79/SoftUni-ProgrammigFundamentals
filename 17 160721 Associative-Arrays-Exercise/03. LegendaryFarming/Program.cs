using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryFarm = new Dictionary<string, int>();
            legendaryFarm.Add("shards", 0);
            legendaryFarm.Add("fragments", 0);
            legendaryFarm.Add("motes", 0);

            while (legendaryFarm["shards"] < 250 && legendaryFarm["fragments"] < 250 && legendaryFarm["motes"] < 250)
            {
                List<string> items = Console.ReadLine().ToLower().Split().ToList();
                while (items.Count != 0)
                {
                    int quantity = int.Parse(items[0]);
                    string item = items[1];

                    if (!legendaryFarm.ContainsKey(item))
                    {
                        legendaryFarm.Add(item, quantity);
                        items.RemoveRange(0, 2);
                        continue;
                    }
                    legendaryFarm[item] += quantity;
                    items.RemoveRange(0, 2);
                    if (legendaryFarm["shards"] >= 250 || legendaryFarm["fragments"] >= 250 || legendaryFarm["motes"] >= 250)
                    {
                        break;
                    }
                }
            }
            Dictionary<string, int> legendaryItems = legendaryFarm.Take(3).ToDictionary(i => i.Key, i => i.Value);
            int winnerValue = legendaryItems.Values.Max();
            string winnerKey = legendaryItems.First(i => i.Value == winnerValue).Key;
            string winner = string.Empty;

            if (winnerKey == "shards")
            {
                winner = "Shadowmourne";
            }
            if (winnerKey == "fragments")
            {
                winner = "Valanyr";
            }
            if (winnerKey == "motes")
            {
                winner = "Dragonwrath";
            }
            Console.WriteLine($"{winner} obtained!");
            legendaryItems[winnerKey] -= 250;

            legendaryFarm.Remove("shards");
            legendaryFarm.Remove("fragments");
            legendaryFarm.Remove("motes");

            foreach (var (key, value) in legendaryItems.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
            {
                Console.WriteLine($"{key}: {value}");
            }
            foreach (var (key, value) in legendaryFarm.OrderBy(i => i.Key))
            {
                Console.WriteLine($"{key}: {value}");
            }
        }
    }
}
