using System;

namespace SplitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = "1 2 3 pesho gosho 4".Split();

            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i]+ " ");
            }
        }
    }
}
