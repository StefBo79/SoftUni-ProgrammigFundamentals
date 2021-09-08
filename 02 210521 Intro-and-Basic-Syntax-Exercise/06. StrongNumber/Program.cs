using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int firstNumber = inputNumber;
            int sum = 0;

            while (inputNumber > 0)
            {
                int currentNumber = inputNumber % 10;
                int factoriel = 1;

                for (int i = 1; i <= currentNumber; ++i)
                {
                    factoriel *= i;
                }
                sum += factoriel;
                inputNumber /= 10;
            }
            if (firstNumber == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
