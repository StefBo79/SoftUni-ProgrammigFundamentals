using System;
using System.Collections.Generic;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = new List<string>(Console.ReadLine().Split(", "));

            string command = Console.ReadLine();
            while (command != "Craft!")
            {
                string[] commandArgs = command.Split(" - ");
                string action = commandArgs[0];

                if (action == "Collect")
                {
                    string item = commandArgs[1];

                    if (inventory.Contains(item))
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        inventory.Add(item);
                    }
                }

                if (action == "Drop")
                {
                    string item = commandArgs[1];
                    if (!inventory.Contains(item))
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        inventory.Remove(item);
                    }
                }

                if (action == "Combine Items")
                {
                    string[] splittted = commandArgs[1].Split(":");
                    string oldItem = splittted[0];
                    string newItem = splittted[1];

                    int index = inventory.IndexOf(oldItem);

                    if (index >= 0)
                    {
                        inventory.Insert(index + 1, newItem);
                    }

                }

                if (action == "Renew")
                {
                    string item = commandArgs[1];


                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
