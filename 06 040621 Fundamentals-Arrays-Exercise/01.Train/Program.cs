using System;
using System.Linq;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];

            int sum = 0;

            for (int i = 0; i < train.Length; i++)
            {
                int people = int.Parse(Console.ReadLine());
                train[i] = people;
                sum += train[i];
            }
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write(train[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
