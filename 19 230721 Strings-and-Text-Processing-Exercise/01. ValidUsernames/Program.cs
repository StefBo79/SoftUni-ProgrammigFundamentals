using System;
using System.Linq;


namespace _01._ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] username = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            //sh, too_long_username, !lleg@l ch@rs, jeffbutt

            foreach (var currentUsername in username)
            {
                if (currentUsername.Length < 3 || currentUsername.Length > 16)
                {
                    continue;
                }
                bool isValid = false;

                foreach (var symbol in currentUsername)
                {
                    if (!(char.IsLetterOrDigit(symbol) || symbol == '_' || symbol == '-'))
                    {
                        isValid = false;
                        break;
                    }
                    isValid = true;
                }
                if (isValid)
                {
                    Console.WriteLine(currentUsername);
                }
            }
        }
    }
}
