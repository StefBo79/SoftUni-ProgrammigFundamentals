using System;

namespace _01._PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                if (command == "TakeOdd")
                {
                    string odd = String.Empty;
                    for (int i = 1; i < input.Length; i+= 2)
                    {
                        odd += input[i];
                    }
                    input = odd.ToString();
                    Console.WriteLine(input);
                }

                if (command.Contains("Cut"))
                {
                    string[] splitted = command.Split(" ");
                    int index = int.Parse(splitted[1]);
                    int lenght = int.Parse(splitted[2]);

                    input = input.Remove(index, lenght);

                    Console.WriteLine(input);              
                }

                if (command.Contains("Substitute"))
                {
                    string[] splitted = command.Split(" ");
                    string oldIndex = splitted[1];
                    string newIndex = splitted[2];

                    if (input.Contains(oldIndex))
                    {
                        input = input.Replace(oldIndex, newIndex);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }                    
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
