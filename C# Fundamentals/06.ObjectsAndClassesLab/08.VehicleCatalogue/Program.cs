using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new CatalogVehicle();
            catalog.Trucks = new List<Truck>();
            catalog.Cars = new List<Car>();
            
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] data = input.Split("/");

                string type = data[0];
                string brand = data[1];
                string model = data[2];
                string horsePowerOrWeight = data[3];

                if (type == "Truck")
                {
                    Truck currentTruck = new Truck();

                    currentTruck.Brand = brand;
                    currentTruck.Model = model;
                    currentTruck.Weight = horsePowerOrWeight;

                    catalog.Trucks.Add(currentTruck);
                }
                else if (type == "Car")
                {
                    Car currentCar = new Car();

                    currentCar.Brand = brand;
                    currentCar.Model = model;
                    currentCar.HorsePower = horsePowerOrWeight;

                    catalog.Cars.Add(currentCar);
                }

                input = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                List<Car> sortedCars = catalog.Cars.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (var car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                List<Truck> sortedTrucks = catalog.Trucks.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (var truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
        }
        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }
        }
        class CatalogVehicle
        {
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }
    }
}
