using System;

namespace _02._VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            var sum = VowelsCounters(input);
            Console.WriteLine(sum);
        }

        private static int VowelsCounters(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];

                if (currentChar == 'a' || currentChar == 'A')
                {
                    sum += 1;
                }
                else if (currentChar == 'e' || currentChar == 'E')
                {
                    sum += 1;
                }
                else if (currentChar == 'o' || currentChar == 'O')
                {
                    sum += 1;
                }
                else if (currentChar == 'u' || currentChar == 'U')
                {
                    sum += 1;
                }
                else if (currentChar == 'i' || currentChar == 'I')
                {
                    sum += 1;
                }
            }
            return sum;
        }
    }
}
