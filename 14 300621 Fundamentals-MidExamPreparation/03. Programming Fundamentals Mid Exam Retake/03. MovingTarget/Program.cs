using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                var splitted = command.Split();
                string commandAction = splitted[0];
                string firstValue = splitted[1];
                string secondValue = splitted[2];
                int index = int.Parse(firstValue);
                int value = int.Parse(secondValue);

                if (commandAction == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                if (commandAction == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                if (commandAction == "Strike")
                {
                    int start = index - value;
                    int end = index + value;
                    if (start >= 0 && end < targets.Count) 
                    {
                        targets.RemoveRange(start, end - start + 1);
                        //targets.RemoveAt(index);
                        //targets.RemoveAt(start);
                        //targets.RemoveAt(end);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
