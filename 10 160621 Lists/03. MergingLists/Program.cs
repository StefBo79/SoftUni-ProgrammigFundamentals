using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstCollection = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            
            List<int> secondCollection = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int maxCount = Math.Max(firstCollection.Count, secondCollection.Count);

            for (int i = 0; i < maxCount; i++)
            {
                if (i < firstCollection.Count)
                {
                    result.Add(firstCollection[i]);
                }
                if (i < secondCollection.Count)
                {
                    result.Add(secondCollection[i]);
                }
            }

            Console.WriteLine(string.Join(' ', result));

        }
    }
}
