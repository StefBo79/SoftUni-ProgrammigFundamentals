using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._ChangeList
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

                if (commandArgs[0] == "Delete")
                {
                    int numberToDeleted = int.Parse(commandArgs[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == numberToDeleted)
                        {
                            numbers.Remove(numberToDeleted);
                        }
                    }
                }
                else if (commandArgs[0] == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);
                    int numberToBeInserted = int.Parse(commandArgs[1]);
                    numbers.Insert(index, numberToBeInserted);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
