using System;

namespace _7._ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string separator = Console.ReadLine();

            Console.WriteLine($"{name1}{separator}{name2}");
        }
    }
}