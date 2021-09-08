using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+[3][5][9](\-|\ )[2]\1[0-9]{3}\1[0-9]{4}\b";
            string numbers = Console.ReadLine();

            MatchCollection matches = Regex.Matches(numbers, pattern);

            Console.WriteLine(string.Join(", ", matches));

        }
    }
}
