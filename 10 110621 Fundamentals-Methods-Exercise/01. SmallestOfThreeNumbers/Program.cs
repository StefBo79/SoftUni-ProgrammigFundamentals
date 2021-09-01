using System;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            
            int smallestNum = FindSmallestNumber(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(smallestNum);
        }

        private static int FindSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {

            int smallestNum = 0;
            if (firstNumber <= secondNumber && firstNumber <= thirdNumber)
            {
                smallestNum =  firstNumber;
            }
            else if (secondNumber <= firstNumber && secondNumber <= thirdNumber)
            {
                smallestNum = secondNumber;
            }
            else if (thirdNumber <= firstNumber && thirdNumber <= secondNumber)
            {
                smallestNum = thirdNumber;
            }
            return smallestNum;
        }
    }
}
