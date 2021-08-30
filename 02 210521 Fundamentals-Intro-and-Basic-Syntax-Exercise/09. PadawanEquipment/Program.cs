using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBels = double.Parse(Console.ReadLine());

            double totalSum = priceOfLightsabers * Math.Ceiling(countOfStudents * 1.1) + priceOfRobes * countOfStudents + priceOfBels * (countOfStudents - (countOfStudents / 6));

            if (totalSum <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalSum - amountOfMoney:f2}lv more.");
            }
        }
    }
}
