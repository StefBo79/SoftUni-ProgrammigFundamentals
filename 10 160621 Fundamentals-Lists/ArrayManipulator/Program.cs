using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                //first 5 even
                string[] commandArgs = input.Split();
                string action = commandArgs[0];

                if (action == "exchange")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }

                    Exchange(numbers, index);
                }
                else if (action == "max")
                {
                    int isEven = commandArgs[1] == "even" ? 0 : 1;
                    int index = GetMax(numbers, isEven);
                    PrintIndex(index);
                }
                else if (action == "min")
                {
                    int isEven = commandArgs[1] == "even" ? 0 : 1;
                    int index = GetMin(numbers, isEven);
                    PrintIndex(index);
                }
                else if (action == "first")
                {
                    int count = int.Parse(commandArgs[1]);
                    int isEven = commandArgs[2] == "even" ? 0 : 1;

                    if (count > numbers.Count || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                        input = Console.ReadLine();
                        continue;
                    }

                    List<int> elements = GetFirst(numbers, count, isEven);
                    PrintElements(elements);
                }
                else if (action == "last")
                {
                    int count = int.Parse(commandArgs[1]);
                    int isEven = commandArgs[2] == "even" ? 0 : 1;

                    if (count > numbers.Count)
                    {
                        Console.WriteLine("Invalid count");
                        input = Console.ReadLine();
                        continue;
                    }

                    List<int> elements = GetLast(numbers, count, isEven);
                    PrintElements(elements);
                }

                input = Console.ReadLine();
            }

            PrintElements(numbers);
        }

        private static List<int> GetLast(List<int> numbers, int count, int isEven)
        {
            List<int> result = new List<int>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (result.Count == count)
                {
                    break;
                }

                if (numbers[i] % 2 == isEven)
                {
                    result.Add(numbers[i]);
                }
            }

            result.Reverse();

            return result;
        }

        private static void PrintElements(List<int> elements)
        {
            if (elements.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", elements)}]");
            }
        }

        private static List<int> GetFirst(List<int> numbers, int count, int isEven)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (count == result.Count)
                {
                    break;
                }

                if (numbers[i] % 2 == isEven)
                {
                    result.Add(numbers[i]);
                }
            }

            return result;
        }

        private static int GetMin(List<int> numbers, int isEven)
        {
            int minIndex = -1;
            int minNumber = int.MaxValue;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] < minNumber && numbers[i] % 2 == isEven)
                {
                    minNumber = numbers[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        private static int GetMax(List<int> numbers, int isEven)
        {
            int maxIndex = -1;
            int maxNumber = int.MinValue;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] > maxNumber && numbers[i] % 2 == isEven)
                {
                    maxIndex = i;
                    maxNumber = numbers[i];
                }
            }

            return maxIndex;
        }

        private static void Exchange(List<int> numbers, int index)
        {
            for (int i = 0; i <= index; i++)
            {
                int currentElement = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(currentElement);
            }
        }

        private static void PrintIndex(int index)
        {
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
