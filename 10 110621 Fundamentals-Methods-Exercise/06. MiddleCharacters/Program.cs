using System;

namespace _06._MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = GetMiddleChar(input);

            Console.WriteLine(result);

        }

        private static string GetMiddleChar(string input)
        {
            string result = string.Empty;

            if (input.Length % 2 == 1)
            {
                result = input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2 - 1].ToString();
                result += input[input.Length / 2];
            }
            return result;
        }
    }
}
