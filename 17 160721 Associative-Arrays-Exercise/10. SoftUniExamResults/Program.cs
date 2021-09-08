using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            //Pesho-Java-84
            //exam finished

            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] inputData = input.Split('-');
                string username = inputData[0];
                string language = inputData[1];

                if (language == "banned")
                {
                    //logic
                    results.Remove(username);
                    input = Console.ReadLine();
                    continue;
                }
                
                
                int points = int.Parse(inputData[2]);

                if (!results.ContainsKey(username))
                {
                    results.Add(username, points);
                }
                else if (results[username] < points)
                {
                    results[username] = points;
                }

                if (!submissions.ContainsKey(language))
                {
                    submissions.Add(language, 0);
                }
                submissions[language]++;

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var (username, points) in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{username} | {points}");
            }

            Console.WriteLine("Submissions:");
            foreach (var (language, count) in submissions.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{language} - {count}");
            }

        }
    }
}
