using System;
using System.Linq;

namespace _06._EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFound = false;

            if (input.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0; 
                
                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += input[j];
                }

                int rightSum = 0;

                for (int k = i + 1; k < input.Length; k++)
                {
                    rightSum += input[k];
                }

                isFound = leftSum == rightSum;
                if (isFound)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
