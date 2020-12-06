using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeedIII
{
    class Car
    {
        public Car(int mileage, int fuelAvailable)
        {
            Mileage = mileage;
            FuelAvailable = fuelAvailable;
        }

        public int Mileage { get; set; }
        public int FuelAvailable { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] currentCar = Console.ReadLine().Split("|");

                string carModel = currentCar[0];
                int mileage = int.Parse(currentCar[1]);
                int fuelAvailable = int.Parse(currentCar[2]);

                Car car = new Car(mileage, fuelAvailable);

                cars.Add(carModel, car);
            }

            string inputCommand = Console.ReadLine();

            while (inputCommand != "Stop")
            {
                string[] command = inputCommand.Split(" : ");
                string currentCommand = command[0];
                string carModel = command[1];

                if (currentCommand == "Drive")
                {
                    int distance = int.Parse(command[2]);
                    int fuel = int.Parse(command[3]);

                    if (fuel > cars[carModel].FuelAvailable)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[carModel].Mileage += distance;
                        cars[carModel].FuelAvailable -= fuel;

                        Console.WriteLine($"{carModel} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (cars[carModel].Mileage >= 100000)
                        {
                            cars.Remove(carModel);
                            Console.WriteLine($"Time to sell the {carModel}!");
                        }
                    }
                }
                else if (currentCommand == "Refuel")
                {
                    int fuel = int.Parse(command[2]);

                    if (fuel + cars[carModel].FuelAvailable > 75)
                    {
                        fuel = 75 - cars[carModel].FuelAvailable;
                        cars[carModel].FuelAvailable = 75;

                    }
                    else
                    {
                        cars[carModel].FuelAvailable += fuel;
                    }

                    Console.WriteLine($"{carModel} refueled with {fuel} liters");
                }
                else if (currentCommand == "Revert")
                {
                    int kilometers = int.Parse(command[2]);

                    if (cars[carModel].Mileage - kilometers < 10000)
                    {
                        cars[carModel].Mileage = 10000;
                    }
                    else
                    {
                        cars[carModel].Mileage -= kilometers;

                        Console.WriteLine($"{carModel} mileage decreased by {kilometers} kilometers");
                    }
                }

                inputCommand = Console.ReadLine();
            }

            foreach (var car in cars.OrderByDescending(x=>x.Value.Mileage)
                                    .ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.FuelAvailable} lt.");
            }
        }
    }
}
