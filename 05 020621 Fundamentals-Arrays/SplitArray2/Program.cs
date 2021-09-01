using System;

namespace SplitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = Console.ReadLine().Split();
            int[] num = new int[test.Length];

            for (int i = 0; i < test.Length; i++)
            {
                num[i] = int.Parse(test[i]);
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"[{i}] = {num[i]}");
            }
        }
    }
}
