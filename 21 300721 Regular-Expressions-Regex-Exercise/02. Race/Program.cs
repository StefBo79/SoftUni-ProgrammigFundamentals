using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racerDistance = new Dictionary<string, int>();
            string namePattern = @"[A-Z]|[a-z]";
            string distancePattern = @"[0-9]";

            List<string> participants = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection names = Regex.Matches(input, namePattern);
                MatchCollection distance = Regex.Matches(input, distancePattern);
                string name = string.Join("", names);
                int dist = 0;

                foreach (Match match in distance)
                {
                    dist += int.Parse(match.Value);
                }
                if (!racerDistance.ContainsKey(name) && participants.Contains(name))
                {
                    racerDistance.Add(name, 0);
                }
                if (participants.Contains(name))
                {
                    racerDistance[name] += dist;
                }
                
                input = Console.ReadLine();
            }

            racerDistance = racerDistance.OrderByDescending(r => r.Value).ToDictionary(k => k.Key, v => v.Value);
            Console.WriteLine($"1st place: {racerDistance.ElementAt(0).Key}");
            Console.WriteLine($"2nd place: {racerDistance.ElementAt(1).Key}");
            Console.WriteLine($"3rd place: {racerDistance.ElementAt(2).Key}");
        }
    }
}
