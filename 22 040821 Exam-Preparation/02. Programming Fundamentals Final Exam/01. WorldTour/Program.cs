using System;
using System.Text;

namespace _01._WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stops = new StringBuilder(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] commandArgs = command.Split(":");
                string action = commandArgs[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(commandArgs[1]);
                    string stop = commandArgs[2];

                    if (index >= 0 && index <= stops.Length)
                    {
                        stops.Insert(index, stop);
                    }

                    Console.WriteLine(string.Join("", stops));
                }

                if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    

                    if (startIndex >= 0 && startIndex <= stops.Length -1 && endIndex >= 0 && endIndex <= stops.Length - 1)
                    {
                        stops.Remove(startIndex, endIndex - startIndex + 1);
                    }

                    Console.WriteLine(string.Join("", stops));
                }

                if (action == "Switch")
                {
                    string oldString = commandArgs[1];
                    string newString = commandArgs[2];

                    if (stops.ToString().Contains(oldString))
                    {
                        stops.Replace(oldString, newString);
                    }

                    Console.WriteLine(string.Join("", stops));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
