using System;

namespace _03._CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            CharInRange(firstChar, secondChar);
        }

        private static void CharInRange(char firstChar, char secondChar)
        {
            int StartingChar = Math.Min(firstChar, secondChar);
            int EndingChar = Math.Max(firstChar, secondChar);

            for (int i = StartingChar + 1; i < EndingChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
