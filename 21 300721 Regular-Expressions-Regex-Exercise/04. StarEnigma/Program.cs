using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanet = new List<string>();
            List<string> destroyedPlanet = new List<string>();

            string KeyPattern = "[STARstar]";
            string pattern = @"@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>[0-9]+)[^@\-!:>]*(?<atackDestruction>![AD]!)[^@\-!:>]*->(?<soldiers>[0-9]+)";

            int counter = int.Parse(Console.ReadLine());
          

            for (int i = 0; i < counter; i++)
            {
                StringBuilder sb = new StringBuilder();
                string input = Console.ReadLine();
                int count = Regex.Matches(input, KeyPattern).Count;

                foreach (char item in input)
                {
                    sb.Append((char)(item - count));
                }

                Match match = Regex.Match(sb.ToString(), pattern);

                if (!match.Success)
                {
                    continue;
                }

                string planetName = match.Groups["planet"].Value;
                int population = int.Parse(match.Groups["population"].Value);
                string atackDestruction = match.Groups["atackDestruction"].Value;
                int soldiers = int.Parse(match.Groups["soldiers"].Value);                

                if (atackDestruction == "!A!")
                {
                    attackedPlanet.Add(planetName);                    
                }
                else
                {
                    destroyedPlanet.Add(planetName);
                }                
            }

            Console.WriteLine($"Attacked planets: {attackedPlanet.Count}");
            foreach (var item in attackedPlanet.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}");
            foreach (var item in destroyedPlanet.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
