using System;

namespace _2._PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] reversedNumber = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                reversedNumber[i] = numbers[numbers.Length - 1 - i];
            }

            for (int i = 0; i < reversedNumber.Length; i++)
            {
                Console.Write(reversedNumber[i] + " ");
            }
        }
    }
}
