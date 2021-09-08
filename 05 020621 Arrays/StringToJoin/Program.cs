using System;

namespace StringToJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            string joined = String.Join("hopa", array);

            Console.WriteLine(joined);
        }
    }
}
