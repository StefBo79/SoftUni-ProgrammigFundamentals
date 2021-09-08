using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>();            

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();

                string[] commandArg = command.Split();
                string firstCommand = commandArg[0];
                string username = commandArg[1];

                //unregister Jony
                if (firstCommand == "unregister")
                {
                    if (parking.ContainsKey(username))
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                        continue;
                    }
                    continue;
                }

                string licensePlateNumber = commandArg[2];

                //register John CS1234JS
                if (firstCommand == "register")
                {
                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        continue;
                    }
                    else
                    {
                        parking.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
            }

            foreach (var (key, value) in parking)
            {
                Console.WriteLine($"{key} => {value}");
            }
        }
    }
}
