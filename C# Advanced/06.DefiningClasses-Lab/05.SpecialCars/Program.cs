using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string tireInput = Console.ReadLine();

            Dictionary<int, Tire[]> allTires = new Dictionary<int, Tire[]>();
            int tiresCount = 0;

            while (tireInput != "No more tires")
            {
                string[] tireInfo = tireInput.Split();

                var tires = new Tire[4]
                {
                    new Tire(int.Parse(tireInfo[0]), double.Parse(tireInfo[1])),
                    new Tire(int.Parse(tireInfo[2]), double.Parse(tireInfo[3])),
                    new Tire(int.Parse(tireInfo[4]), double.Parse(tireInfo[5])),
                    new Tire(int.Parse(tireInfo[6]), double.Parse(tireInfo[7])),
                };

                allTires.Add(tiresCount, tires);
                tiresCount++;

                tireInput = Console.ReadLine();
            }

            string engineInput = Console.ReadLine();

            Dictionary<int, Engine> engines = new Dictionary<int, Engine>();
            int engineCount = 0;

            while (engineInput != "Engines done")
            {
                string[] engineInfo = engineInput.Split();
                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engineCount, engine);
                engineCount++;

                engineInput = Console.ReadLine();
            }

            string carInput = Console.ReadLine();

            List<Car> specialCars = new List<Car>();

            while (carInput != "Show special")
            {
                string[] carInfo = carInput.Split();
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], allTires[tiresIndex]);
                specialCars.Add(car);

                carInput = Console.ReadLine();
            }

            bool canDrive = true;

            foreach (Car car in specialCars)
            {
                canDrive = car.Year >= 2017 &&
                           car.Engine.HorsePower > 330 &&
                           car.Tires.Select(t => t.Pressure).Sum() > 9 &&
                           car.Tires.Select(t => t.Pressure).Sum() < 10;

                if (canDrive)
                {
                    car.Drive(0.20);

                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}
