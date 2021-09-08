using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> heroesHP = new Dictionary<string, int>();
            Dictionary<string, int> heroesMP = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var splitted = Console.ReadLine().Split();
                string name = splitted[0];
                int hp = int.Parse(splitted[1]);
                int mp = int.Parse(splitted[2]);

                heroesHP.Add(name, hp);
                heroesMP.Add(name, mp);
            }
            string command = Console.ReadLine();

            while (command != "End")
            {               
                if (command.Contains("CastSpell"))
                {
                    var splitted = command.Split(" - ");
                    string heroName = splitted[1];
                    int mnNeeded = int.Parse(splitted[2]);
                    string spellName = splitted[3];

                    if (heroesMP[heroName] < mnNeeded)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                    else
                    {
                        heroesMP[heroName] -= mnNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesMP[heroName]} MP!");
                    }
                }

                if (command.Contains("TakeDamage"))
                {
                    var splitted = command.Split(" - ");
                    string heroName = splitted[1];
                    int damage = int.Parse(splitted[2]);
                    string attacker = splitted[3];

                    if (heroesHP[heroName] > damage)
                    {
                        heroesHP[heroName] -= damage;
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesHP[heroName]} HP left!");
                    }
                    else
                    {
                        heroesHP[heroName] = 0;
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }

                if (command.Contains("Recharge"))
                {
                    var splitted = command.Split(" - ");
                    string heroName = splitted[1];
                    int amountRecharged = int.Parse(splitted[2]);

                    if (heroesMP[heroName] + amountRecharged > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - heroesMP[heroName]} MP!");
                        heroesMP[heroName] = 200;
                    }
                    else
                    {
                        heroesMP[heroName] += amountRecharged;
                        Console.WriteLine($"{heroName} recharged for {amountRecharged} MP!");
                    }
                }

                if (command.Contains("Heal"))
                {
                    var splitted = command.Split(" - ");
                    string heroName = splitted[1];
                    int amountHealed = int.Parse(splitted[2]);

                    if (heroesHP[heroName] + amountHealed > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - heroesHP[heroName]} HP!");
                        heroesHP[heroName] = 100;
                    }
                    else
                    {
                        heroesHP[heroName] += amountHealed;
                        Console.WriteLine($"{heroName} healed for {amountHealed} HP!");
                    }
                }

                command = Console.ReadLine();
            }

            heroesHP = heroesHP
                .Where(h => h.Value > 0)
                .OrderByDescending(h => h.Value)
                .ThenBy(h => h.Key)
                .ToDictionary(h => h.Key, h => h.Value);

            foreach (var hero in heroesHP)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value}");
                Console.WriteLine($"  MP: {heroesMP[hero.Key]}");
            }

        }
    }
}
