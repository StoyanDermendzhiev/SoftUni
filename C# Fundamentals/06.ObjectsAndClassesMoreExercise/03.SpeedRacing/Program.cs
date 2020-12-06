using System;
using System.Collections.Generic;

namespace _03.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> trackedCars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCar = Console.ReadLine().Split();

                string model = inputCar[0];
                int fuelAmount = int.Parse(inputCar[1]);
                double fuelConsumption = double.Parse(inputCar[2]);
                double traveledDistance = 0;

                Car currentCar = new Car(model, fuelAmount, fuelConsumption, traveledDistance);

                trackedCars.Add(currentCar);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] currentCommand = command.Split();
                string model = currentCommand[1];
                double kmToTraveled = double.Parse(currentCommand[2]);

                trackedCars.Find(x => x.Model == model).MoveCar(trackedCars, model, kmToTraveled);

                command = Console.ReadLine();
            }

            foreach (Car currentCar in trackedCars)
            {
                Console.WriteLine(currentCar);
            }
        }
    }

    class Car
    {
        public void MoveCar(List<Car> trackedCars, string model, double kmToTraveled)
        {
            double fuelConsumption = trackedCars.Find(x => x.Model == model).FuelConsumption;
            double fuelAmount = trackedCars.Find(x => x.Model == model).FuelAmount;

            if (fuelConsumption * kmToTraveled <= fuelAmount)
            {
                trackedCars.Find(x => x.Model == model).FuelAmount -= fuelConsumption * kmToTraveled;
                trackedCars.Find(x => x.Model == model).TraveledDistance += kmToTraveled;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public Car(string model, double fuelAmount, double fuelConsumption, double traveledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
            TraveledDistance = traveledDistance;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double TraveledDistance { get; set; }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TraveledDistance}";
        }
    }
}
