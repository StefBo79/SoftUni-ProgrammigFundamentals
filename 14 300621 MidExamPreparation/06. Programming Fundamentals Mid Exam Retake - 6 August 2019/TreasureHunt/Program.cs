using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLoot = Console.ReadLine()
                .Split('|')
                .ToList();

            string command = Console.ReadLine();

            List<string> lootedList = new List<string>();

            while (command != "Yohoho!")
            {
                string[] splitted = command.Split();
                

                if (splitted[0] == "Loot")
                {
                    for (int i = 1; i < splitted.Length; i++)
                    {
                        if (!initialLoot.Contains(splitted[i]))
                        {
                            initialLoot.Insert(0, splitted[i]);
                        }
                    }
                }
                else if (splitted[0] == "Drop")
                {
                    if (int.Parse(splitted[1]) > 0 && int.Parse(splitted[1]) < initialLoot.Count)
                    {
                        string temp = initialLoot[int.Parse(splitted[1])];
                        initialLoot.RemoveAt(int.Parse(splitted[1]));
                        initialLoot.Add(temp);
                    }                   
                }
                else if (splitted[0] == "Steal")
                {
                    int itemsToSteal = int.Parse(splitted[1]);
                    if (itemsToSteal > initialLoot.Count)
                    {
                        itemsToSteal = initialLoot.Count;
                    }
                    lootedList = initialLoot.TakeLast(itemsToSteal).ToList();
                    initialLoot.RemoveRange(initialLoot.Count - itemsToSteal, itemsToSteal);
                    Console.WriteLine(string.Join(", ", lootedList));
                    lootedList.Clear();
                }

                command = Console.ReadLine();
            }
            if (initialLoot.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
                return;
            }

            double averageSum = 0;
            foreach (var item in initialLoot)
            {
                averageSum += item.Length;
            }
            averageSum /= initialLoot.Count;

            Console.WriteLine($"Average treasure gain: {averageSum:f2} pirate credits.");
        }
    }
}
