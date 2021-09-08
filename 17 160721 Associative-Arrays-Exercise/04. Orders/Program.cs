using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                // Beer 2.20 100
                string[] inputInfo = input.Split();
                string productName = inputInfo[0];
                double productPrice = double.Parse(inputInfo[1]);
                int productQty = int.Parse(inputInfo[2]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new double[2]);
                }

                double previousQty = products[productName][1];
                double[] priceQty = new double[] { productPrice, previousQty + productQty };
                products[productName] = priceQty;

                input = Console.ReadLine();
            }

            foreach (var (key, value) in products)
            {
                double totalPrice = value[0] * value[1];
                Console.WriteLine($"{key} -> {totalPrice:f2}");
            }
        }
    }
}
