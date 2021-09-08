using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> pirates = new Dictionary<string, int[]>();

            string input = Console.ReadLine();
            while (input != "Sail")
            {
                string[] inputInfo = input.Split("||");
                string town = inputInfo[0];
                int population = int.Parse(inputInfo[1]);
                int gold = int.Parse(inputInfo[2]);

                if (!pirates.ContainsKey(town))
                {
                    pirates.Add(town, new int[] { population, gold });
                }
                else
                {
                    int[] currentValues = pirates[town];
                    currentValues[0] += population;
                    currentValues[1] += gold;
                }               

                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                //Plunder=>Tortuga=>75000=>380
                //Prosper=>Santo Domingo=>180

                string[] inputInfo = input.Split("=>");
                string action = inputInfo[0];
                

                if (action == "Plunder")
                {
                    string town = inputInfo[1];
                    int population = int.Parse(inputInfo[2]);
                    int gold = int.Parse(inputInfo[3]);

                    int[] values = pirates[town];
                    values[0] -= population;
                    values[1] -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {population} citizens killed.");

                    if (values[0] <= 0 || values[1] <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        pirates.Remove(town);
                    }
                }
                else if (action == "Prosper")
                {
                    string town = inputInfo[1];
                    int gold = int.Parse(inputInfo[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    
                    int[] values = pirates[town];
                    values[1] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {values[1]} gold.");
                }

                input = Console.ReadLine();
            }
            if (pirates.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {pirates.Count} wealthy settlements to go to:");
                foreach (var p in pirates.OrderByDescending(x=> x.Value[1]).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{p.Key} -> Population: {p.Value[0]} citizens, Gold: {p.Value[1]} kg");
                }
            }            
        }
    }
}
