using System;
using System.Linq;

namespace readNumbersFromSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"number[{i}] = {number[i]}");
            }

        }
    }
}
