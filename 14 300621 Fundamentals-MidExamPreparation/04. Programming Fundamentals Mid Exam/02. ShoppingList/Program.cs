using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("!").ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                var commandArgs = command.Split();
                string commandCondition = commandArgs[0];
                string commandItem = commandArgs[1];
                

                if (commandCondition == "Urgent")
                {
                    if (!items.Contains(commandItem))
                    {
                        items.Insert(0, commandItem);
                    }
                }
                if (commandCondition == "Unnecessary")
                {
                    if (items.Contains(commandItem))
                    {
                        items.Remove(commandItem);
                    }
                }
                if (commandCondition == "Correct")
                {                    
                    string oldItem = commandArgs[1];
                    string newItem = commandArgs[2];

                    int index = items.IndexOf(oldItem);

                    if (items.Contains(oldItem))
                    {
                        items.Insert(index + 1, newItem);
                        items.Remove(oldItem);
                    }
                }
                if (commandCondition == "Rearrange")
                {
                    if (items.Contains(commandItem))
                    {                        
                        items.Remove(commandItem);
                        items.Add(commandItem);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", items));
        }
    }
}
