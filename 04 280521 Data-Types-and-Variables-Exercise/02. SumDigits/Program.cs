using System;

namespace _2._SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            while (inputNumber > 0)
            {
               sum += inputNumber % 10;
                inputNumber = inputNumber / 10;
            }
            Console.WriteLine(sum);
        }
    }
}