using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i +1}.{products[i]} ");
            }


        }
    }
}
