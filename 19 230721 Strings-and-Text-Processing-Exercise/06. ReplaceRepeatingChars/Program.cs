using System;

namespace _06._ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    Console.Write(input[i]);
                }
                else if (input[i + 1] == input.Length)
                {
                    Console.Write(input[1]);
                }
            }
            Console.Write(input[input.Length - 1]);
        }
    }
}
