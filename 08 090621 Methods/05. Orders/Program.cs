using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;
            double sum = 0;

            price = CheckOrder(order, price);
            sum = quantity * price;

            Console.WriteLine($"{sum:f2}");
        }

        static double CheckOrder(string order, double price)
        {
            if (order == "coffee")
            {
                price = 1.50;
            }
            else if (order == "water")
            {
                price = 1.00;
            }
            else if (order == "coke")
            {
                price = 1.40;
            }
            else if (order == "snacks")
            {
                price = 2.00;
            }

            return price;
        }
    }
}
