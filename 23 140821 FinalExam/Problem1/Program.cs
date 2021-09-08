using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Finish")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "Replace")
                {
                    string currentChar = commandArgs[1];
                    string newChar = commandArgs[2];

                    while (message.Contains(currentChar))
                    {
                        message = message.Replace(currentChar, newChar);
                    }

                    Console.WriteLine(message);
                }

                if (action == "Cut")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    if (startIndex >= 0 && startIndex < message.Length && endIndex >= 0 && endIndex < message.Length)
                    {
                        message = message.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }

                if (action == "Make")
                {
                    string UpperLower = commandArgs[1];

                    if (UpperLower == "Upper")
                    {
                        message = message.ToUpper();
                        Console.WriteLine(message);
                    }
                    else
                    {
                        message = message.ToLower();
                        Console.WriteLine(message);
                    }
                }

                if (action == "Check")
                {
                    string checkedMessage = commandArgs[1];

                    if (message.Contains(checkedMessage))
                    {
                        Console.WriteLine($"Message contains {checkedMessage}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {checkedMessage}");
                    }

                }

                if (action == "Sum")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    int length = (endIndex - startIndex) + 1;
                    int sum = 0;

                    if (startIndex > 0 && endIndex < message.Length)
                    {
                        string substring = message.Substring(startIndex, length);

                        for (int i = 0; i < substring.Length; i++)
                        {
                            sum += substring[i];
                        }

                        Console.WriteLine(sum);

                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine();
        }
    }
}