using System;

namespace _9._SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yeild = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int days = 0;

            while (yeild >= 100)
            {
                totalAmount += yeild - 26;
                days++;
                yeild -= 10;
            }
            if (days > 0)
            {
                totalAmount -= 26;
            }
            
            Console.WriteLine(days);
            Console.WriteLine(totalAmount);
        }
    }
}
