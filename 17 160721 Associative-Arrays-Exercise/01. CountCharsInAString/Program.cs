using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> charsCount = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && !charsCount.ContainsKey(text[i]))
                {
                    charsCount.Add(text[i], 1);
                    continue;
                }
                if (text[i] != ' ')
                {
                    charsCount[text[i]]++;
                }
            }
            foreach (var (key, value) in charsCount)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
