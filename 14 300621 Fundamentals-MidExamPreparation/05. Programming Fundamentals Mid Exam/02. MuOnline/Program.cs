using System;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");
            int initialHealth = 100;
            int coins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] splitted = rooms[i].Split();
                string command = splitted[0];
                int amount = int.Parse(splitted[1]);

                if (command == "potion")
                {
                    initialHealth += amount;

                    if (initialHealth > 100)
                    {
                        amount -= initialHealth - 100;
                        initialHealth = 100;
                    }

                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if (command == "chest")
                {
                    Console.WriteLine($"You found {amount} bitcoins.");
                    coins += amount;
                }
                else
                {
                    if (initialHealth > amount)
                    {
                        Console.WriteLine($"You slayed {command}.");
                        initialHealth -= amount;
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }

                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {coins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}