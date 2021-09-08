using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();


            for (int i = 0; i < numOfCommands; i++)
            {
                string message = Console.ReadLine();
                List<string> messages = message.Split().ToList();

                if (messages[2] == "going!")
                {
                    if (guests.Contains(messages[0]))
                    {
                        Console.WriteLine($"{messages[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(messages[0]);
                    }
                }
                else if (messages[2] == "not")
                {
                    if (guests.Contains(messages[0]))
                    {
                        guests.Remove(messages[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{messages[0]} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(string.Join(' ', guests[i]));
            }
        }
    }
}
