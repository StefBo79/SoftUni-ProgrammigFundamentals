using System;
using System.Linq;

namespace _08._MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());

            //int magicSum = 0;
            int currentSum = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    currentSum = input[i] + input[j];

                    if (currentSum == magicNumber)
                    {
                        Console.Write(input[i] + " " + input[j]);
                        Console.WriteLine();
                    }
                }
                //currentSum = input[i] + input[i + 1];
                //Console.Write(currentSum + " ");                
            }

        }
    }
}
