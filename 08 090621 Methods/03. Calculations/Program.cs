using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            AddMethod(command, a, b);
            MultiplyMethod(command, a, b);
            SubtractMethod(command, a, b);
            DivideMethod(command, a, b);

        }

        static void AddMethod(string command, int a, int b)
        {
            if (command == "add")
            {
                Console.WriteLine(a + b);
            }
            
        }
        static void MultiplyMethod(string command, int a, int b)
        {
            if (command == "multiply")
            {
                Console.WriteLine(a * b);
            }
            
        }
        static void SubtractMethod(string command, int a, int b)
        {
            if (command == "subtract")
            {
                Console.WriteLine(a - b);
            }

        }static void DivideMethod(string command, int a, int b)
        {
            if (command == "divide")
            {
                Console.WriteLine(a / b);
            }

        }
    }
}
