using System;
using System.Collections.Generic;
using System.Linq;

namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShipStatus = Console.ReadLine()
                .Split('>')
                .Select(int.Parse)
                .ToList();

            List<int> warShipStatus = Console.ReadLine()
                .Split('>')
                .Select(int.Parse)
                .ToList();

            int maximuHealth = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            bool isSink = false;

            while (command != "Retire")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Fire")
                {
                    int index = int.Parse(commandArgs[1]);
                    int damage = int.Parse(commandArgs[2]);

                    if (index > 0 && index <= warShipStatus.Count)
                    {
                        warShipStatus[index] -= damage;
                        if (warShipStatus[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            isSink = true;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            if (!isSink)
            {
                Console.WriteLine(string.Join(" ", warShipStatus));
            }
            
        }
    }
}
