using System;

namespace _08._FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            long FactorielOfA = Factorial(a);
            long FactorielOfB = Factorial(b);

            double result = (double)FactorielOfA / FactorielOfB;
            Console.WriteLine($"{result:f2}");
        }

        static long Factorial(int integer)
        {
            long fact = 1;
            for (int i = 1; i <= integer; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

    }
}
