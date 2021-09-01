using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxPax = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Add")
                {
                    int passangers = int.Parse(commandArgs[1]);
                    wagons.Add(passangers);
                }
                else
                {
                    int passangers = int.Parse(commandArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangers <= maxPax)
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
