using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }
            if (typeOfDay == "Weekday")
            {
                if (age <= 18)
                {
                    price = 12;
                }
                if (age > 18 && age <= 64)
                {
                    price = 18;
                }
                if (age > 64)
                {
                    price = 12;
                }
            }
            if (typeOfDay == "Weekend")
            {
                if (age <= 18)
                {
                    price = 15;
                }
                if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                if (age > 64)
                {
                    price = 15;
                }
            }
            if (typeOfDay == "Holiday")
            {
                if (age <= 18)
                {
                    price = 5;
                }
                if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                if (age > 64)
                {
                    price = 10;
                }
            }
            Console.WriteLine($"{price}$");
        }
    }
}
