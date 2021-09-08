using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombCoordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int number = bombCoordinates[0];
            int range = bombCoordinates[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    for (int j = i - range; j <= i + range; j++)
                    {
                        if (j < 0 || j >= numbers.Count)
                        {
                            continue;
                        }

                        numbers[j] = 0;
                    }
                }
            }

            Console.WriteLine(numbers.Sum());

           
        }
    }
}
