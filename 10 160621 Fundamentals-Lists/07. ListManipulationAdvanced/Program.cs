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

            //List<int> printEven = new List<int>();

            string command = Console.ReadLine();
            int countChanges = 0;

            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                

                if (action == "Add")
                {
                    int element = int.Parse(commandArgs[1]);
                    numbers.Add(element);
                    countChanges++;
                }

                else if (action == "Remove")
                {
                    int element = int.Parse(commandArgs[1]);
                    numbers.Remove(element);
                    countChanges++;
                }

                else if (action == "RemoveAt")
                {
                    int element = int.Parse(commandArgs[1]);
                    numbers.RemoveAt(element);
                    countChanges++;
                }

                else if (action == "Insert")
                {
                    int element = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, element);
                    countChanges++;
                }

                else if (action == "Contains")
                {
                    int element = int.Parse(commandArgs[1]);
                    if (numbers.Contains(element))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (action == "PrintEven")
                {               
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }

                else if (action == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();                    
                }

                else if (action == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }

                else if (action == "Filter")
                {
                    if (commandArgs[1] == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > int.Parse(commandArgs[2]))
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }

                    else if (commandArgs[1] == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= int.Parse(commandArgs[2]))
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }

                    else if (commandArgs[1] == "<=") 
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= int.Parse(commandArgs[2]))
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }

                    else if (commandArgs[1] == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < int.Parse(commandArgs[2]))
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine();
            }
            if (countChanges != 0)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
            
        }
    }
}
