using System;
using System.Collections.Generic;
using System.Linq;

namespace biscuits
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> biscuits = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command = Console.ReadLine();
            while (command != "No More Money")
            {
                string[] commandArgs = command.Split().ToArray();                

                if (commandArgs[0] == "OutOfStock")
                {
                   string type = commandArgs[1];
                    for (int i = 0; i < biscuits.Count; i++)
                    {
                        if (biscuits[i] == type)
                        {
                            biscuits[i] = "None";
                        }
                    }         
                }
                else if (commandArgs[0] == "Required")
                {
                    string type = commandArgs[1];
                    int index = int.Parse(commandArgs[2]);
                    if (index >= 0 && index < biscuits.Count && biscuits[index] != "None")
                    {
                        if (!biscuits.Contains(type))
                        {
                            biscuits.Insert(index, type);
                            biscuits.RemoveAt(index + 1);
                        }
                    }                    
                }
                else if (commandArgs[0] == "Last")
                {
                    biscuits.Add(commandArgs[1]);
                }            

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", biscuits.Where(b => b != "None")));
        }
    }
}
