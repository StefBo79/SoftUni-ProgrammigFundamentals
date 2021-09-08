using System;

namespace _01._ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 0;
            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "special" || command == "regular")
                {
                    break;
                }
                double price11 = double.Parse(command);

                if (price11 < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                price += price11;
            }

            double priceNoTax = price;
            price *= 1.20;
            double taxes = price - priceNoTax;

            if (command == "special")
            {
                price *= 0.90;
            }
            if (price == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!{Environment.NewLine}Price without taxes: {priceNoTax:f2}${Environment.NewLine}Taxes: {taxes:f2}${Environment.NewLine}-----------{Environment.NewLine}Total price: {price:f2}$");
            }
            
        }
    }
}
