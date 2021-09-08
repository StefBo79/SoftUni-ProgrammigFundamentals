using System;

namespace _05._AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            
            int sumOfFirstTwo = Sum(firstInt, secondInt);
            int subtractFromFirstTwo = Subtract(sumOfFirstTwo, thirdInt);
            Console.WriteLine(subtractFromFirstTwo);


        }
        static int Sum(int firstInt, int secondInt)
        {            
            int sum = firstInt + secondInt;
            return sum;
        }
        static int Subtract(int sumOfFirstTwo, int thirdInt)
        {
            int subtract = sumOfFirstTwo - thirdInt;
            return subtract;
        }
    }
}
