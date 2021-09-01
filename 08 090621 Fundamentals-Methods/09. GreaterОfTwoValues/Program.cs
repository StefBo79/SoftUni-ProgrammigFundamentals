using System;

namespace _09._GreaterОfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secoundValue = Console.ReadLine();

            if (type == "int")
            {
                int firstInt = int.Parse(firstValue);
                int secoundInt = int.Parse(secoundValue);
                int result = GetMax(firstInt, secoundInt);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secoundChar = char.Parse(secoundValue);
                char result = (char)GetMax(firstChar, secoundChar);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string result = GetMax(firstValue, secoundValue);
                Console.WriteLine(result);
            }

            
        }
        static int GetMax(int firstInt, int secoundInt)
        {
            if (firstInt > secoundInt)
            {
                return firstInt;
            }

            return secoundInt;
        }

        static string GetMax(string firstValue, string secoundValue)
        {
            int result = firstValue.CompareTo(secoundValue);

            int firstValueSum = GetValueOfASCII(firstValue);
            int secoundValueSum = GetValueOfASCII(secoundValue);

            if (result > 0)
            {
                return firstValue;
            }            
            
            return secoundValue;
             
        }

        private static int GetValueOfASCII(string value)
        {
            int valueSum = 0;

            for (int i = 0; i < value.Length; i++)
            {
                valueSum += value[i];
            }

            return valueSum;
        }
    }
}
