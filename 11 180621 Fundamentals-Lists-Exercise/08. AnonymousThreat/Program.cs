using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split()               
                .ToList();

            string command = Console.ReadLine();

            while (command != "3:1")
            {
                //merge 0 3
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int startIndex = int.Parse(commandArgs[1]);
                int endIndex = int.Parse(commandArgs[2]);

                if (action == "merge")
                {                  

                    string mergedString = String.Empty;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex >= names.Count)
                    {
                        startIndex = names.Count - 1;
                    }
                    
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        if (startIndex < 0 || startIndex >= names.Count)
                        {
                            continue;
                        }
                        mergedString += names[startIndex];
                        names.RemoveAt(startIndex);
                        
                    }                   
                    names.Insert(startIndex, mergedString);
                }
                else if (action == "divide")
                {
                    int index = startIndex;
                    int partitions = endIndex;

                    string element = names[index];
                    names.RemoveAt(index);
                    int parts = element.Length / partitions;
                    List<string> dividedElements = new List<string>();

                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string currentElement = element.Substring(parts * i, parts);
                        dividedElements.Add(currentElement);
                    }
                    
                       string lastElement = element.Substring(parts * (partitions - 1));
                       dividedElements.Add(lastElement);
  

                    names.InsertRange(index, dividedElements);
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
