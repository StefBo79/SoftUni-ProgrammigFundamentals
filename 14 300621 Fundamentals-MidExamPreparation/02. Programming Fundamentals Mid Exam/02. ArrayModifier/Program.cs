using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] splitted = command.Split();
                //string commandAction = splitted[0];
                //string commandIndex1 = splitted[1];
                //string commandIndex2 = splitted[2];

                if (splitted[0] == "swap")
                {
                    int index1 = int.Parse(splitted[1]);
                    int index2 = int.Parse(splitted[2]);
                    int temp = elements[index1];
                    elements[index1] = elements[index2];
                    elements[index2] = temp;
                }
                if (splitted[0] == "multiply")
                {
                    int indexM1 = int.Parse(splitted[1]);
                    int indexM2 = int.Parse(splitted[2]);
                    elements[indexM1] *= elements[indexM2];
                }
                if (splitted[0] == "decrease")
                {
                    for (int i = 0; i < elements.Count; i++)
                    {
                        elements[i] -= 1;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
