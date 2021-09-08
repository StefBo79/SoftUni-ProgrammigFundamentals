using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> kvp = new SortedDictionary<string, string>();

            string[] daemonNames = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in daemonNames)
            {
                int deamonHealth = item.Where(c => !char.IsNumber(c) && c != '.' && c != '+' && c != '-' && c != '*' && c != '/').Sum(x => x);

                MatchCollection matches = Regex.Matches(item, @"([-+0-9]{1,}\.{0,1}[0-9]+)|[-+0-9]");

                decimal totalSumMinus = 0;

                foreach (Match match in matches)
                {
                    var isMinus = match.Value.Contains("-");
                    if (isMinus)
                    {
                        var currentValue = match.Value.Replace("-", string.Empty);
                        totalSumMinus -= decimal.Parse(currentValue);
                    }
                    else
                    {
                        var currentValue = match.Value.Replace("+", string.Empty);
                        totalSumMinus += decimal.Parse(currentValue);
                    }
                }

                var mutlDivision = Regex.Matches(item, @"[*\/]");

                foreach (Match ope in mutlDivision)
                {
                    if (ope.Value == "*")
                    {
                        totalSumMinus *= 2;
                    }
                    else
                    {
                        totalSumMinus /= 2;
                    }
                }

                if (!kvp.ContainsKey(item))
                {
                    kvp.Add(item, $"{deamonHealth} health, {totalSumMinus:F2} damage");
                }
            }
            foreach (var item in kvp)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
