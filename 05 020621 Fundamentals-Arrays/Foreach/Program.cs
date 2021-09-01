using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (var number in numbers)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
