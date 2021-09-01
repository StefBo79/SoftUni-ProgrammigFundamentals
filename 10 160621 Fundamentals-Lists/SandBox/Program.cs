using System;
using System.Collections.Generic;
using System.Linq;


namespace _Sand_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                names[i] = name;


            }
            Console.WriteLine(string.Join(" ", names));
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int n = int.Parse(Console.ReadLine());

    //        List<string> names = new List<string>();

    //        for (int i = 0; i < n; i++)
    //        {
    //            string name = Console.ReadLine();

    //            names.Add(name);
    //        }

    //        Console.WriteLine(string.Join(" ", names));
    //    }
    //}
}
