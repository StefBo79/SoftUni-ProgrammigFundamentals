using System;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysPirating = int.Parse(Console.ReadLine());
            int plunderPerDay = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double currentPlunder = 0;

            for (int i = 1; i <= daysPirating; i++)
            {
                currentPlunder += plunderPerDay;
                if (i % 3 == 0 && i >= 3)
                {
                    currentPlunder += (double)plunderPerDay / 2;
                }

                if (i % 5 == 0 && i >= 5)
                {
                    currentPlunder *= 0.70;
                }
            }

            if (currentPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {currentPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {currentPlunder / expectedPlunder * 100:f2}% of the plunder.");
            }
        }
    }
}
