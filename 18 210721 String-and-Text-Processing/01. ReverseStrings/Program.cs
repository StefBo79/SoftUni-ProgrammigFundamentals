using System;

namespace _01._ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            

            while (line != "end")
            {
                string reversed = String.Empty;

                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversed += line[i];                    
                }
                Console.WriteLine($"{line} = {reversed}");
                line = Console.ReadLine();                
            }

        }
    }
}
