using System;
using System.Collections.Generic;
using System.Linq;


namespace _04._Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] sorted = numbers.OrderByDescending(n => n).ToArray();

            Console.WriteLine(string.Join(" ", sorted.Take(3).ToArray()));
        }
    }
}
