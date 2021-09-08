using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02._FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(?<start>^@#+)(?<middle>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$");
            var digitRegex = new Regex(@"\d");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["middle"].Value;
                    var digitMatch = digitRegex.Matches(name);
                    string productGroup = String.Empty;

                    foreach (Match digit in digitMatch)
                    {
                        if (digit.Success)
                        {
                            productGroup += digit.Value;
                        }
                    }
                    if (productGroup.Length == 0)
                    {
                        productGroup = "00";
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}