using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfProduts = Console.ReadLine()
                .Split("|")
                .ToList();

            string command = Console.ReadLine();

            while (command != "Shop!")
            {
                string[] splitted = command.Split("%");
                string action = splitted[0];
                

                if (action == "Important")
                {
                    string product1 = splitted[1];
                    string tempProduct = String.Empty;
                    if (!listOfProduts.Contains(product1))
                    {
                        listOfProduts.Insert(0, product1);
                    }
                    else
                    {
                        tempProduct = product1;
                        listOfProduts.Remove(product1);
                        listOfProduts.Insert(0, tempProduct);
                    }
                }
                else if (action == "Add")
                {
                    string product1 = splitted[1];
                    if (!listOfProduts.Contains(product1))
                    {
                        listOfProduts.Add(product1);
                    }
                    else
                    {
                        Console.WriteLine("The product is already in the list.");
                    }
                }
                else if (action == "Swap")
                {
                    string product1 = splitted[1];
                    string product2 = splitted[2];                    
                    string swapedProduct = string.Empty;

                    if (listOfProduts.Contains(product1) && listOfProduts.Contains(product2))
                    {
                        int indexP1 = listOfProduts.FindIndex(p => p == product1);
                        int indexP2 = listOfProduts.FindIndex(p => p == product2);
                        swapedProduct = listOfProduts[indexP1];
                        listOfProduts[indexP1] = listOfProduts[indexP2];
                        listOfProduts[indexP2] = swapedProduct;
                    }
                    else if (!listOfProduts.Contains(product1))
                    {
                        Console.WriteLine($"Product {product1} missing!");
                    }
                    else if (!listOfProduts.Contains(product2))
                    {
                        Console.WriteLine($"Product {product2} missing!");
                    }
                }
                else if (action == "Reversed") 
                {
                    listOfProduts.Reverse();
                }
                
                command = Console.ReadLine();
            }
            int counter = 1;
            foreach (var item in listOfProduts)
            {
                counter++;
                Console.WriteLine($"{counter}. {item}");
            }
        }
    }
}
