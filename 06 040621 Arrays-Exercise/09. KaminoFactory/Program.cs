using System;
using System.Linq;

namespace _09._KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int aplicationMaxSequence = 0;
            int mostLeftIndex = int.MaxValue;
            int maxSumOfOnces = 0;

            int bestDNA = 1;
            int currentDNA = 0;

            int[] result = null;

            while (command != "Clone them!")
            {
                int[] numbers = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int sumOfOnes = 0;
                int maxSequence = 0;
                int currentSequence = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0)
                    {
                        currentSequence = 0;
                        continue;
                    }
                    sumOfOnes++;
                    currentSequence++;

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                }
                string targetString = new string('1', maxSequence);
                int currentIndex = string.Join("", numbers).IndexOf(targetString);

                currentDNA++;

                if (maxSequence >= aplicationMaxSequence && currentIndex < mostLeftIndex || maxSequence == aplicationMaxSequence && currentIndex == mostLeftIndex && sumOfOnes > maxSumOfOnces)
                {
                    aplicationMaxSequence = maxSequence;
                    mostLeftIndex = currentIndex;
                    maxSumOfOnces = sumOfOnes;
                    bestDNA = currentDNA;
                    result = numbers;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestDNA} with sum: {maxSumOfOnces}.");
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
