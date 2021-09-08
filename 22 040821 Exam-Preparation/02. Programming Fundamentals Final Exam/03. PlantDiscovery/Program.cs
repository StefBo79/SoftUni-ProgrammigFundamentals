using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plantList = new Dictionary<string, int>();
            Dictionary<string, List<double>> ratingList = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());            

            for (int i = 0; i < n; i++)
            {
                
                string[] input = Console.ReadLine().Split("<->");
                string plant = input[0];
                int rarity = int.Parse(input[1]);
                if (!plantList.ContainsKey(plant))
                {
                    plantList.Add(plant, rarity);
                    ratingList.Add(plant, new List<double>());
                }
                else
                {
                    plantList[plant] = rarity;
                }
            }

            string[] command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Exhibition")
            {                
                string[] plant = command[1].TrimStart().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                if (!plantList.ContainsKey(plant[0]))
                {
                    Console.WriteLine("error");
                    command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                //string action = commandArgs[0];
                //string plant = commandArgs[1];

                if (command[0] == "Rate")
                {
                    
                    if (!ratingList.ContainsKey(plant[0]))
                    {
                        Console.WriteLine("error");
                        command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }

                    
                    int rating = int.Parse(plant[1]);
                    ratingList[plant[0]].Add(rating);
                    
                }

                if (command[0] == "Update")
                {                    
                    int rarity = int.Parse(plant[1].Trim());
                    plantList[plant[1]] = rarity;
                }

                if (command[0] == "Reset")
                {
                    ratingList[plant[0]].Clear();
                    
                }

                command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine("Plants for the exhibition:");

            var sorted = plantList
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => ratingList[x.Key].Count > 0
                    ? ratingList[x.Key].Sum() / ratingList[x.Key].Count
                    : 0.0);
            foreach (var (plant, rarity) in sorted)
            {
                var averageRating = ratingList[plant].Count > 0
                    ? ratingList[plant].Sum() / ratingList[plant].Count
                    : 0.0;
                Console.WriteLine($"- {plant}; Rarity: {rarity}; Rating: {averageRating:F2}");
            }
        }
    }
}