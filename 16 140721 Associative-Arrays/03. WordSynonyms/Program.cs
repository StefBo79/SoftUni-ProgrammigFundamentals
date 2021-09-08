using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonims = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (!synonims.ContainsKey(word))
                {
                    synonims.Add(word, new List<string>());
                    synonims[word].Add(synonim);
                }
                else
                {
                    synonims[word].Add(synonim);
                }                
            }
            foreach (var (key, value) in synonims)
            {
                Console.WriteLine($"{key} - {string.Join(", ", value)} ");
            }
        }
    }
}
