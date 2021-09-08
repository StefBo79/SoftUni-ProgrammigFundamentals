using System;

namespace _08._MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Power(number, power);
        }

         static double Power(double number, double power)
        {
            double result = 0;
            Console.WriteLine(Math.Pow(number, power));

            return result;
        }
    }
}
