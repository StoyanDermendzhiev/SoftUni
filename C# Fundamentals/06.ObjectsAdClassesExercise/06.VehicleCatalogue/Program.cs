using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Vehicle> vehicleCatalogue = new List<Vehicle>();

            while (input != "End")
            {
                string[] line = input.Split();
                string type = line[0];
                string model = line[1];
                string color = line[2];
                int horsepower = int.Parse(line[3]);

                Vehicle currentVehicle = new Vehicle(type, model, color, horsepower);

                vehicleCatalogue.Add(currentVehicle);

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {
                List<Vehicle> printVehicle = vehicleCatalogue.FindAll(x => x.Model == command);

                foreach (Vehicle currenVehicle in printVehicle)
                {
                    Console.WriteLine(currenVehicle);
                }

                command = Console.ReadLine();
            }

            List<Vehicle> cars = vehicleCatalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> trucks = vehicleCatalogue.Where(x => x.Type == "truck").ToList();

            double carsHorsepowerSum = cars.Sum(x => x.Horsepower);
            double trucksHorsepowerSum = trucks.Sum(x => x.Horsepower);

            double averageCarHorsepower = 0;
            double averageTruckHorespower = 0;

            if (cars.Count > 0)
            {
                averageCarHorsepower = carsHorsepowerSum / cars.Count;
            }
            if (trucks.Count > 0)
            {
                averageTruckHorespower = trucksHorsepowerSum / trucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorespower:f2}.");
        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            return sb.ToString().Trim();
        }
    }
}
