using System;
using System.Linq;
using System.Text;

namespace _01._SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] commandArg = command.Split(":|:");
                string action = commandArg[0];

                if (action == "InsertSpace")
                {
                    int index = int.Parse(commandArg[1]);

                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }                

                if (action == "Reverse")
                {
                    string substring = commandArg[1];
                    int index = message.ToString().IndexOf(substring);

                    if (!message.ToString().Contains(substring))
                    {
                        Console.WriteLine("error");
                        command = Console.ReadLine();
                        continue;
                    }

                    substring = string.Join("", substring.ToCharArray().Reverse());                                
                    message.Remove(index, substring.Length);
                    message.Append(substring);

                    Console.WriteLine(message);
                }

                if (action == "ChangeAll")
                {
                    string substring = commandArg[1];
                    string replacement = commandArg[2];

                    if (message.ToString().Contains(substring))
                    {
                        message.Replace(substring, replacement);
                    }

                    Console.WriteLine(message);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
