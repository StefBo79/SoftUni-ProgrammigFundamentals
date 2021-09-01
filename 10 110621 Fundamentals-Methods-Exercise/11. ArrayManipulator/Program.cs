using System;
using System.Linq;

namespace _11._ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "exchange") 
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index > number.Length)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }

                    Exchange(number, index);
                    Console.WriteLine(string.Join(" ", number));
                }
                else if (action == "max")
                {
                    string evenOddCommand = commandArgs[1];
                    int evenOddNumber = GetEvenOddNumber(evenOddCommand);
                    int maxIndex = GetMax(number, evenOddNumber);

                    if (maxIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxIndex);
                    }
                    
                }
                else if (action == "min")
                {
                    string evenOddCommand = commandArgs[1];
                    int evenOddNumber = GetEvenOddNumber(evenOddCommand);
                    int minIndex = GetMin(number, evenOddNumber);

                    if (minIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minIndex);
                    }
                }
                else if (action == "first")
                {
                    int count = int.Parse(commandArgs[1]);
                    int evenOddNumber = GetEvenOddNumber(commandArgs[2]);

                    if (count > number.Length)
                    {
                        Console.WriteLine("Inavalid Count");
                        int[] firstNumber = GetFirstNumber(number, evenOddNumber, count);
                        Console.WriteLine(string.Join(" ", firstNumber));
                    }
                }
            }
        }

        private static int[] GetFirstNumber(int[] number, int evenOddNumber, int count)
        {
            int arrayLength = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (arrayLength == count)
                {
                    break;
                }
                if (number[i] % 2 == evenOddNumber && arrayLength == count)
                {
                    arrayLength++;
                }
            }
            int[] firstNumber = new int[arrayLength];
            int counter = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (arrayLength == 0)
                {
                    break;
                }

                if (number[i] % 2 == evenOddNumber)
                {
                    firstNumber[counter++] = number[i];
                    arrayLength--;
                }
            }
            return firstNumber;
        }

        private static int GetMin(int[] number, int evenOddNumber)
        {
            int minIndex = -1;
            int minValue = int.MaxValue;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] < minValue && number[i] % 2 == evenOddNumber )
                {
                    minValue = number[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        private static int GetEvenOddNumber(string evenOddCommand)
        {
            if (evenOddCommand == "even")
            {
                return 0;
            }
            return 1;
        }

        private static int GetMax(int[] number, int oddEven)
        {
            int maxIndex = -1;
            int maxNumber = int.MinValue;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] > maxNumber && number[i] % 2 == oddEven)
                {
                    maxNumber = number[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private static void Exchange(int[] number, int index)
        {
            int[] leftArray = new int[index + 1];
            int[] rightArray = new int[number.Length - index - 1];

            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = number[i];
            }

            int counter = 0;

            for (int i = index + 1; i < number.Length; i++)
            {
                rightArray[counter++] = number[i];
            }

            for (int i = 0; i < rightArray.Length; i++)
            {
                number[i] = rightArray[i];
            }

            counter = 0;

            for (int i = number.Length - index - 1; i < number.Length; i++)
            {
                number[i] = leftArray[counter++];
            }

        }
    }
}
