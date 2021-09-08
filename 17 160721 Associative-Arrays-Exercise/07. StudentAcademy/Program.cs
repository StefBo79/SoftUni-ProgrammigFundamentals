using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentInformation = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            //John
            //5.5
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());                    

                if (!studentInformation.ContainsKey(name))
                {
                    studentInformation.Add(name, new List<double>());
                    studentInformation[name].Add(grade);
                    continue;                    
                }
                studentInformation[name].Add(grade);
            }

            studentInformation = studentInformation
                .Where(s => s.Value.Average() >= 4.5)
                .ToDictionary(s => s.Key, s => s.Value);

            foreach (var student in studentInformation.OrderByDescending(i => i.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
            }
        }
    }
}
