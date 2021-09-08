using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();
            int indexOfWord = text.IndexOf(wordToRemove);

            while (indexOfWord >= 0)
            {
                text = text.Remove(indexOfWord, wordToRemove.Length);
                indexOfWord = text.IndexOf(wordToRemove);
            }
            Console.WriteLine(text);
            
        }
    }
}
