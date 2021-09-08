using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaitingForTheLift = int.Parse(Console.ReadLine());
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < wagons.Count; i++)
            {
                while (wagons[i] < 4)
                {
                    if (peopleWaitingForTheLift <= 0)
                    {
                        break;
                    }
                    peopleWaitingForTheLift--;
                    wagons[i]++;
                }
            }
            if (peopleWaitingForTheLift <= 0 && !wagons.All(w => w == 4))
            {
                Console.WriteLine($"The lift has empty spots!{Environment.NewLine}{string.Join(' ', wagons)}");
            }
            else if (peopleWaitingForTheLift > 0 && wagons.All(w => w == 4))
            {
                Console.WriteLine($"There isn't enough space! {peopleWaitingForTheLift} people in a queue!{Environment.NewLine}{string.Join(" ", wagons)}");
            }
            else if (peopleWaitingForTheLift <= 0 && wagons.All(w => w == 4))
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
