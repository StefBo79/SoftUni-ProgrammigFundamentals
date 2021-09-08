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
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> heroHP = new Dictionary<string, int>();
            Dictionary<string, int> heroMP = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string heroName = input[0];
                int health = int.Parse(input[1]);
                int mana = int.Parse(input[2]);

                heroHP.Add(heroName, health);
                heroMP.Add(heroName, mana);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split(" - ");
                string action = commandArgs[0];

                if (action == "CastSpell")
                {
                    string heroName = commandArgs[1];
                    int mpNeeded = int.Parse(commandArgs[2]);
                    string spellName = commandArgs[3];

                    if (heroMP[heroName] < mpNeeded)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");          
                    }
                    else
                    {
                        heroMP[heroName] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroMP[heroName]} MP!");
                    }
                }

                if (action == "TakeDamage")
                {
                    string heroName = commandArgs[1];
                    int damage = int.Parse(commandArgs[2]);
                    string attacker = commandArgs[3];

                    if (heroHP[heroName] > damage)
                    {
                        heroHP[heroName] -= damage;
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroHP[heroName]} HP left!");
                    }
                    else
                    {
                        heroHP[heroName] = 0;
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }

                if (action == "Recharge")
                {
                    string heroName = commandArgs[1];
                    int manaAmount = int.Parse(commandArgs[2]);

                    if (heroMP[heroName] + manaAmount > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - heroMP[heroName]} MP!");
                        heroMP[heroName] = 200;
                    }
                    else
                    {
                        heroMP[heroName] += manaAmount;
                        Console.WriteLine($"{heroName} recharged for {manaAmount} MP!");
                    }
                }

                if (action == "Heal")
                {
                    string heroName = commandArgs[1];
                    int health = int.Parse(commandArgs[2]);

                    if (heroHP[heroName] + health > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - heroHP[heroName]} HP!");
                        heroHP[heroName] = 100;
                    }
                    else
                    {
                        heroHP[heroName] += health;
                        Console.WriteLine($"{heroName} healed for {health} HP!");
                    }
                }
                command = Console.ReadLine();
            }

            heroHP = heroHP
                .Where(h => h.Value > 0)
                .OrderByDescending(h => h.Value)
                .ThenBy(h => h.Key)
                .ToDictionary(h => h.Key, h => h.Value);

            foreach (var hero in heroHP)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value}");
                Console.WriteLine($"  MP: {heroMP[hero.Key]}");
            }
        }
    }
}
