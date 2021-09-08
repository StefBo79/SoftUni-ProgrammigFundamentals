using System;
using System.Collections.Generic;
using System.Linq;


namespace _06._ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int element = int.Parse(commandArgs[1]);

                if (action == "Add")
                {
                    numbers.Add(element);
                }
                else if (action == "Remove")
                {
                    numbers.Remove(element);
                }
                else if (action == "RemoveAt")
                {
                    numbers.RemoveAt(element);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, element);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
