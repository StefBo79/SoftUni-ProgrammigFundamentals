using System;

namespace _09._PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool isPalindrome = IsPalindrome(input);
                Console.WriteLine(isPalindrome);

                input = Console.ReadLine();
            }
        }
        static bool IsPalindrome(string input)
        {
            string reversedInput = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }
            bool isPalindrome = input == reversedInput;
            return isPalindrome;
        }
    }
}
