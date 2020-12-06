using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                int speed = int.Parse(carInfo[1]);
                int power = int.Parse(carInfo[2]);
                int weight = int.Parse(carInfo[3]);
                string type = carInfo[4];

                Engine engineInfo = new Engine(speed, power);
                Cargo cargoData = new Cargo(weight, type);

                Car currentCar = new Car(model, engineInfo, cargoData);

                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    {
                        List<Car> fragileCargo = cars.FindAll(x => x.CargoData.Type == "fragile" &&
                                                                   x.CargoData.Weight < 1000);

                        if (fragileCargo.Count > 0)
                        {
                            foreach (Car currentCar in fragileCargo)
                            {
                                Console.WriteLine(currentCar.Model);
                            }
                        }
                    }
                    break;
                case "flamable":
                    {
                        List<Car> flamableCargo = cars.FindAll(x => x.CargoData.Type == "flamable" &&
                                                                   x.EngineInfo.Power > 250);

                        if (flamableCargo.Count > 0)
                        {
                            foreach (Car currentCar in flamableCargo)
                            {
                                Console.WriteLine(currentCar.Model);
                            }
                        }
                    }
                    break;
            }
        }
    }

    class Car
    {
        public Car(string model, Engine engineInfo, Cargo cargoData)
        {
            Model = model;
            EngineInfo = engineInfo;
            CargoData = cargoData;
        }

        public string Model { get; set; }
        public Engine EngineInfo { get; set; }
        public Cargo CargoData { get; set; }
    }

    class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get; set; }
        public int Power { get; set; }
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get; set; }
        public string Type { get; set; }
    }
}
