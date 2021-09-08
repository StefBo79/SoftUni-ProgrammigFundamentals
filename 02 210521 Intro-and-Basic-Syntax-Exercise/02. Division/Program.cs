using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int number = 0;
            if (input % 10 == 0)
            {
                number = 10;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (input % 7 == 0)
            {
                number = 7;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (input % 6 == 0)
            {
                number = 6;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (input % 3 == 0)
            {
                number = 3;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (input % 2 == 0)
            {
                number = 2;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (input % 10 != 0 || input % 7 != 0 || input % 6 != 0 || input % 3 != 0 || input % 2 != 0)
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
