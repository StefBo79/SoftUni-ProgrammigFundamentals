using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> townPopulation = new Dictionary<string, int>();
            Dictionary<string, int> townGold = new Dictionary<string, int>();

            string command = Console.ReadLine();
            while (command != "Sail")
            {
                string[] commandArgs = command.Split("||");
                string town = commandArgs[0];
                int population = int.Parse(commandArgs[1]);
                int gold = int.Parse(commandArgs[2]);

                if (townPopulation.ContainsKey(town))
                {
                    int populationInTown = townPopulation[town];
                    int totalPopulation = populationInTown + population;
                    townPopulation[town] = totalPopulation;
                    int goldInTown = townGold[town];                    
                    int totalGold = goldInTown + gold;
                    townGold[town] = totalGold;
                }
                else
                {
                    townPopulation.Add(town, population);
                    townGold.Add(town, gold);
                }                

                command = Console.ReadLine();
            }

            string input = Console.ReadLine();

            while (input != "End")
            {                
                string[] inputArgs = input.Split("=>");
                string action = inputArgs[0];
                if (action == "Plunder")
                {                    
                    string town = inputArgs[1];
                    int people = int.Parse(inputArgs[2]);
                    int gold = int.Parse(inputArgs[3]);

                    int population = townPopulation[town];                    
                    int killedPeople = population - people;
                    townPopulation[town] = killedPeople;

                    int goldInTown = townGold[town];
                    int stealedGold = goldInTown - gold;
                    townGold[town] = stealedGold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (townPopulation[town] <= 0 || townGold[town] <= 0)
                    {
                        townPopulation.Remove(town);
                        townGold.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }

                if (action == "Prosper")
                {
                    string town = inputArgs[1];
                    int gold = int.Parse(inputArgs[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        int goldInTown = townGold[town];
                        int totalGold = goldInTown + gold;
                        townGold[town] = totalGold;

                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {totalGold} gold.");
                    }

                }
                input = Console.ReadLine();
            }

            townGold = townGold
                .OrderByDescending(g => g.Value)
                .ThenBy(g => g.Key)
                .ToDictionary(g => g.Key, g => g.Value);

            Console.WriteLine($"Ahoy, Captain! There are {townPopulation.Count} wealthy settlements to go to:");

            foreach (var gold in townGold)
            {
                Console.WriteLine($"{gold.Key} -> Population: {townPopulation[gold.Key]} citizens, Gold: {townGold[gold.Key]} kg");
            }
        }
    }
}
