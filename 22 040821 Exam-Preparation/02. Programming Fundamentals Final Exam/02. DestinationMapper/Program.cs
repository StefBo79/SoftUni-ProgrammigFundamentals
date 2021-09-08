using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<front>[=\/])(?<dest>[A-Z][A-Za-z]{2,})\1";
            string destinations = Console.ReadLine();
            int travelPoints = 0;

            MatchCollection matches = Regex.Matches(destinations, pattern);

            foreach (Match match in matches)
            {
                travelPoints += match.Groups["dest"].Length;
            }
            
            Console.WriteLine($"Destinations: {string.Join(", ", matches.Select(g => g.Groups["dest"].Value))}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
