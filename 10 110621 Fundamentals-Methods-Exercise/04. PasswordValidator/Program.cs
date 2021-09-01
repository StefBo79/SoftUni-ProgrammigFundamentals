using System;
using System.Linq;

namespace _04._PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValidLength = IsValidLength(password);
            bool isValidSymbols = IsValidSymbols(password);
            bool containsTwoDigits = ContainsTwoDigits(password);

            if (isValidLength && isValidSymbols && containsTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ContainsTwoDigits(string password)
        {
            bool containsTwoDigits = password.Count(char.IsDigit) >= 2;
            if (!containsTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            return true;
        }

        private static bool IsValidSymbols(string password)
        {
            bool isValidSymbols = password.All(char.IsLetterOrDigit);
            if (!isValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
            return true;
        }

        private static bool IsValidLength(string password)
        {
            bool isValidLength = password.Length >= 6 && password.Length <= 10;
            if (!isValidLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }
    }
}