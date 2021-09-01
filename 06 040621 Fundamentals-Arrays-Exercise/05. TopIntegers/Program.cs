using System;
using System.Linq;

namespace _05._TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 4 3 2
            // 4 3 2
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                bool itIsBigger = true;  

                for (int j = i +1 ; j < input.Length; j++)
                {
                    if (input[i] <= input[j])
                    {
                        itIsBigger = false;
                    }
                }
                if (itIsBigger)
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
