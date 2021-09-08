using System;
using System.Text;

namespace _05._DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder special = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    letters.Append(input[i]);
                }
                else if (char.IsDigit(input[i]))
                {
                    digits.Append(input[i]);
                }
                else
                {
                    special.Append(input[i]);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(special);
        }
    }
}
