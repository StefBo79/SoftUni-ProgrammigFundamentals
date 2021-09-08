using System;
using System.Text;

namespace _05._MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            if (input == "0" || multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(input[i].ToString());
                int product = currentDigit * multiplier + remainder;
                int result = product % 10;
                remainder = product / 10;

                sb.Insert(0, result);
            }
            if (remainder > 0)
            {
                sb.Insert(0, remainder);
            }

            Console.WriteLine(sb);
        }
    }
}
