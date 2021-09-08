using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _06._ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<user>(?<=\s)[a-zA-Z0-9]+([-.]\w*)*)(?<verbatim>\@)(?<host>[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
            string input = Console.ReadLine();

            MatchCollection email = Regex.Matches(input, pattern);

            foreach (Match match in email)
            {
                Console.WriteLine(match);
            }
        }
    }
}
