using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> teams = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {
                string splitString = input.Contains(" | ") ? " | " : " -> ";
                string[] inputElements = input.Split(splitString);
                if (input.Contains("|"))
                {
                    string sideName = inputElements[0];
                    string user = inputElements[1];

                    if (!teams.ContainsKey(sideName))
                    {
                        teams.Add(sideName, new List<string>());
                    }
                    if (!teams[sideName].Contains(user) && !teams.Values.Any(x => x.Contains(user)))
                    {
                        teams[sideName].Add(user);
                    }
                }
                else
                {
                    string user = inputElements[0];
                    string sideName = inputElements[1];

                    foreach (var team in teams)
                    {
                        foreach (var currentUser in team.Value)
                        {
                            if (currentUser == user)
                            {
                                team.Value.Remove(user);
                                break;
                            }
                        }
                    }

                    if (!teams.ContainsKey(sideName))
                    {
                        teams.Add(sideName, new List<string>());
                    }
                    teams[sideName].Add(user);
                    Console.WriteLine($"{user} joins the {sideName} side!");
                   
                }              

                input = Console.ReadLine();
            }
            foreach (var item in teams
                    .Where(x => x.Value.Count > 0)
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user} ");
                }
            }
        }
    }
}
