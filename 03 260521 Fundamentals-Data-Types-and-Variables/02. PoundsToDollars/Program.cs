using System;

namespace _2.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal usd = pounds * 1.31m;

            Console.WriteLine($"{usd:f3}");

        }
    }
}
