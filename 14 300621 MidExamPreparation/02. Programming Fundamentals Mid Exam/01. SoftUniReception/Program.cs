using System;

namespace _01._National_Court_Problem_Description
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeHelp = int.Parse(Console.ReadLine());
            int secondEmployeeHelp = int.Parse(Console.ReadLine());
            int thirdEmployeeHelp = int.Parse(Console.ReadLine());
            int countOfPeople = int.Parse(Console.ReadLine());

            int totalPeopleAnsweredPerHour = firstEmployeeHelp + secondEmployeeHelp + thirdEmployeeHelp;

            int hourNeeded = 0;

            while (countOfPeople > 0)
            {
                hourNeeded++;

                if (hourNeeded % 4 == 0)
                {
                    continue;
                }

                countOfPeople -= totalPeopleAnsweredPerHour;
            }

            Console.WriteLine($"Time needed: {hourNeeded}h.");
        }
    }
}