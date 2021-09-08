using System;
using System.Collections.Generic;
using System.Linq;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            int currentIndex = 0;
            int initialIndex = 0;

            while (command != "Love!")
            {
                string[] commandArgs = command.Split();                
                currentIndex += int.Parse(commandArgs[1]);

                if (currentIndex > houses.Count - 1)
                {
                    currentIndex = 0;
                }
                if (houses[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                    command = Console.ReadLine();
                    continue;
                }

                houses[currentIndex] -= 2;
                initialIndex = currentIndex;

                if (houses[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {currentIndex}.");
            Console.WriteLine(houses.All(i => i == 0) ? "Mission was successful." : $"Cupid has failed {houses.Count(i => i > 0)} places.");
        }
    }
}
