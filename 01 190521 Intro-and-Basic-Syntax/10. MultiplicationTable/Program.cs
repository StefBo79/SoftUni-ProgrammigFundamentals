using System;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int times = 1;

            for (int i = times; i <= 10; i++)
            {
                Console.WriteLine($"{input} X {times} = {input * times}");
                times++;
            }

        }
    }
}
