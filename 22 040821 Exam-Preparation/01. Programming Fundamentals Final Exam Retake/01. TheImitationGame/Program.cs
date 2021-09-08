using System;
using System.Text;

namespace _01._TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "Decode")
            {
                string[] inputArgs = input.Split("|");
                string action = inputArgs[0];

                if (action == "Move")
                {
                    int numbersOfLetters = int.Parse(inputArgs[1]);
                    string temp = message.ToString().Substring(0, numbersOfLetters);
                    message.Remove(0, numbersOfLetters);
                    message.Append(temp);
                }
                if (action == "Insert")
                {
                    int index = int.Parse(inputArgs[1]);
                    string value = inputArgs[2];
                    message.Insert(index, value);

                   
                }

                if (action == "ChangeAll")
                {
                    string substring = inputArgs[1];
                    string replacement = inputArgs[2];
                    
                    while (message.ToString().Contains(substring))
                    {
                        message.Replace(substring, replacement);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
