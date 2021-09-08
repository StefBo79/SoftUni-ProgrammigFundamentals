using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> shootedIndexes = new List<int>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                int index = int.Parse(command);
                if (index > targets.Count - 1 || index < 0 || shootedIndexes.Contains(index) )
                {
                    command = Console.ReadLine();
                    continue;
                }

                int initialValue = targets[index];
                targets[index] = -1;
                shootedIndexes.Add(index);

                for (int i = 0; i < targets.Count; i++)
                {
                    if (targets[i] > initialValue && targets[i] != -1)
                    {
                        targets[i] -= initialValue;
                    }
                    else if (targets[i] <= initialValue && targets[i] != -1)
                    {
                        targets[i] += initialValue;
                    }
                }                
                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shootedIndexes.Count} -> {string.Join(" ", targets)}");
        }
    }
}
