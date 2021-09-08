using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var matches = Regex.Matches(input, @"(?<day>[0-9]{2})(.)(?<month>[A-z]{3})\1(?<year>[0-9]{4})");

            foreach (Match match in matches)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;
                
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
