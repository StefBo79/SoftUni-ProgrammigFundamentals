using System;

namespace _11._RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, height = 0;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            double V = 0;
            V = (length * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {V:f2}");
        }
    }
}
