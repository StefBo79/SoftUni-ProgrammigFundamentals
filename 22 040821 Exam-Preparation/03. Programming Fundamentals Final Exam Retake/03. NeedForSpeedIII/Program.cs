using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> carsDist = new Dictionary<string, int>();
            Dictionary<string, int> carsFuel = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());                     

            for (int i = 0; i < n; i++)
            {                
                string[] inputArgs = Console.ReadLine().Split("|");
                string car = inputArgs[0];
                int mileage = int.Parse(inputArgs[1]);
                int fuel = int.Parse(inputArgs[2]);

                carsDist.Add(car, mileage);
                carsFuel.Add(car, fuel);
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] commandArgs = command.Split(" : ");
                string action = commandArgs[0];

                if (action == "Drive")
                {
                    string car = commandArgs[1];
                    int distance = int.Parse(commandArgs[2]);
                    int fuel = int.Parse(commandArgs[3]);

                    if (carsFuel[car] < fuel )
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carsFuel[car] -= fuel;
                        carsDist[car] += distance;

                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (carsDist[car] >= 100_000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            carsDist.Remove(car);
                            carsFuel.Remove(car);
                        }
                    }
                }

                if (action == "Refuel")
                {
                    string car = commandArgs[1];                    
                    int fuel = int.Parse(commandArgs[2]);

                    if (carsFuel[car] + fuel > 75)
                    {
                        Console.WriteLine($"{car} refueled with {75 - carsFuel[car]} liters");
                        carsFuel[car] = 75;
                    }
                    else
                    {
                        carsFuel[car] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }

                if (action == "Revert")
                {
                    string car = commandArgs[1];
                    int kilometers = int.Parse(commandArgs[2]);                    

                    if (carsDist[car] - kilometers > 10_000)
                    {
                        carsDist[car] -= kilometers;
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                    else
                    {
                        carsDist[car] = 10_000;
                    }
                }

                command = Console.ReadLine();
            }

            carsDist = carsDist
                .OrderByDescending(d => d.Value)
                .ThenBy(c => c.Key)
                .ToDictionary(d => d.Key, d => d.Value);


            foreach (var car in carsDist)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {carsFuel[car.Key]} lt.");
                
            }
        }
    }
}