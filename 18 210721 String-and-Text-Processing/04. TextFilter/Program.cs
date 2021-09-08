using System;

namespace _04._TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringOfBannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in stringOfBannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
