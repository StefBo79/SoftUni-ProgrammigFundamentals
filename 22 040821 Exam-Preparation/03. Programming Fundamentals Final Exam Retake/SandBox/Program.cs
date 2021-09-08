using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> carDist = new Dictionary<string, int>();
            Dictionary<string, int> carFuel = new Dictionary<string, int>();

            int numberOfCars = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string cars = input[0];
                int mileage = int.Parse(input[1]);
                int petrol = int.Parse(input[2]);
                carDist.Add(cars, mileage);
                carFuel.Add(cars, petrol);
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

                    if (carFuel[car] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carFuel[car] -= fuel;
                        carDist[car] += distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (carDist[car] >= 100_000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            carDist.Remove(car);
                            carFuel.Remove(car);
                        }
                    } 
                }

                if (action == "Refuel")
                {
                    string car = commandArgs[1];
                    int fuel = int.Parse(commandArgs[2]);

                    if (carFuel[car] + fuel > 75)
                    {
                        Console.WriteLine($"{car} refueled with {75 - carFuel[car]} liters");
                        carFuel[car] = 75;
                    }
                    else
                    {
                        carFuel[car] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }

                if (action == "Revert")
                {
                    string car = commandArgs[1];
                    int distance = int.Parse(commandArgs[2]);

                    if (carDist[car] - distance > 10_000)
                    {
                        carDist[car] -= distance;
                        Console.WriteLine($"{car} mileage decreased by {distance} kilometers");
                    }
                    else
                    {
                        carDist[car] = 10_000;
                    }
                }

                command = Console.ReadLine();
            }

            carDist = carDist
                .OrderByDescending(d => d.Value)
                .ThenBy(c => c.Key)
                .ToDictionary(d => d.Key, d => d.Value);


            foreach (var car in carDist)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {carFuel[car.Key]} lt.");
            }
        }
    }
}
