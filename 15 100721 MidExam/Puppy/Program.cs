using System;

namespace Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityFood = double.Parse(Console.ReadLine());
            double quantityHay = double.Parse(Console.ReadLine());
            double quantityCover = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            double currentFood = quantityFood * 1000;
            double currentHay = quantityHay * 1000;
            double currentCover = quantityCover * 1000;
            double currentWeight = weight * 1000;
            int days = 30;

            for (int i = 1; i <= days; i++)
            {
                currentFood -= 300;                

                if (i % 2 == 0)
                {
                    currentHay -= currentFood - (currentFood * 0.95);                    
                }

                if (i % 3 == 0)
                {
                    currentCover -= currentWeight / 3;                    
                }

            }
            if (currentFood > 0 && currentHay > 0 && currentCover > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {currentFood / 1000:f2}, Hay: {currentHay / 1000:f2}, Cover: {currentCover / 1000:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}
