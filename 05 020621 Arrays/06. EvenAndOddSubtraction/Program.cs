using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenNumbers = 0;
            int oddNumbers = 0;
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    evenNumbers += currentNumber;
                }
                else
                {
                    oddNumbers += currentNumber;
                }
                result = (evenNumbers - oddNumbers);
            }
            Console.WriteLine(result);
        }
    }
}
