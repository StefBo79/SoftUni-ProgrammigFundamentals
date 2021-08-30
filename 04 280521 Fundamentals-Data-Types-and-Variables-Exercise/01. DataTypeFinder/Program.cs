using System;

namespace _1._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int resultInt = 0;
            double resultDouble = 0;
            float resultFloat = 0;
            char resultChar = ' ';
            bool resultBool = true;
            

            while (input != "END")
            {
                if (int.TryParse(input, out resultInt))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out resultDouble))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (float.TryParse(input, out resultFloat))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out resultChar))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out resultBool))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
