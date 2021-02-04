using System;
using System.Collections.Generic;

namespace _06.SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1km = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(model, car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] driveData = input.Split();
                string model = driveData[1];
                int amountOfKm = int.Parse(driveData[2]);

                Car.MoveDistance(cars[model], amountOfKm);

                input = Console.ReadLine();
            }

            foreach (Car car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
