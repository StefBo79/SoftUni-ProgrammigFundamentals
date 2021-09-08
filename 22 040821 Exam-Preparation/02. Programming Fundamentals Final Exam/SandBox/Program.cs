using System;
using System.Linq;
using System.Collections.Generic;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var plantList = new Dictionary<string, int>();
            var ratingList = new Dictionary<string, List<double>>();

            var counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                var input = Console.ReadLine().Split("<->").ToArray();

                var plant = input[0];
                var rarity = int.Parse(input[1]);

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

            while (true)
            {
                var command = Console.ReadLine()
                    .Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Exhibition")
                {
                    break;
                }

                var commandArgs = command[1].Trim()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                var plant = commandArgs[0].Trim();

                if (!plantList.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }

                switch (command[0])
                {
                    case "Rate":
                        {
                            var rating = double.Parse(commandArgs[1].Trim());
                            ratingList[plant].Add(rating);
                            break;
                        }
                    case "Update":
                        {
                            var rarity = int.Parse(commandArgs[1].Trim());
                            plantList[plant] = rarity;
                            break;
                        }
                    case "Reset":
                        ratingList[plant].Clear();
                        break;
                }
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