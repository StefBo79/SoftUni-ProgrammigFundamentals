using System;

namespace _06._CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = Calculate(width, height);

            Console.WriteLine(area);
        }

        static double Calculate(double width, double height)
        {
            return width * height;
        }
    }
}
