using System;

namespace _4._SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string inputChar = Console.ReadLine();
                sum += inputChar[0];
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
