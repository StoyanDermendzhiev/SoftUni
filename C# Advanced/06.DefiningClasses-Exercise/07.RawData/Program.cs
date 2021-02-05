using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split();

                string model = carData[0];
                int engineSpeed = int.Parse(carData[1]);
                int enginePower = int.Parse(carData[2]);
                int cargoWeight = int.Parse(carData[3]);
                string cargoType = carData[4];
                double tire1Pressure = double.Parse(carData[5]);
                int tire1Age = int.Parse(carData[6]);
                double tire2Pressure = double.Parse(carData[7]);
                int tire2Age = int.Parse(carData[8]);
                double tire3Pressure = double.Parse(carData[9]);
                int tire3Age = int.Parse(carData[10]);
                double tire4Pressure = double.Parse(carData[11]);
                int tire4Age = int.Parse(carData[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire[] tires =
                {
                    new Tire(tire1Age, tire1Pressure),
                    new Tire(tire2Age, tire2Pressure),
                    new Tire(tire3Age, tire3Pressure),
                    new Tire(tire4Age, tire4Pressure),
                };

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (Car car in cars.Where(c => c.Cargo.Type == "fragile"))
                {
                    bool isLowPressure = false;

                    foreach (Tire tire in car.Tires)
                    {
                        if (tire.Pressure < 1)
                        {
                            isLowPressure = true;
                        }
                    }

                    if (isLowPressure)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (Car car in cars.Where(c=>c.Cargo.Type == "flamable")
                                        .Where(c=>c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
