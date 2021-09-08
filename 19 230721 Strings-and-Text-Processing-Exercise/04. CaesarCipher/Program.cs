using System;
using System.Text;

namespace _04._CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            text.Append(Console.ReadLine());

            StringBuilder cypher = new StringBuilder();
            
            foreach (var @char in text.ToString())
            {
                cypher.Append((char) (@char + 3));
            }

            Console.WriteLine(cypher);
        }
    }
}
