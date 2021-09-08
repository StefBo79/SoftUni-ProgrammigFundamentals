using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudents = double.Parse(Console.ReadLine());
            double countOfLectures = double.Parse(Console.ReadLine());
            double courseBonus = double.Parse(Console.ReadLine());

            int studentWithMaxBonus = int.MinValue;
            int maxAtt = int.MinValue;

            if (numberOfStudents == 0 || countOfLectures == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }

            for (int i = 0; i < numberOfStudents; i++)
            {
                int attendance = int.Parse(Console.ReadLine());
                double temp = Math.Ceiling(attendance / countOfLectures * (5 + courseBonus));
                if (temp > studentWithMaxBonus)
                {
                    studentWithMaxBonus = (int)temp;
                    maxAtt = attendance;
                }
            }
            Console.WriteLine($"Max Bonus: {studentWithMaxBonus}.");
            Console.WriteLine($"The student has attended {maxAtt} lectures.");
        }
    }
}
