using System;
using System.Collections.Generic;

namespace _08.CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine currEngine = new Engine(engineInfo[0], engineInfo[1]);

                if (engineInfo.Length >= 3)
                {
                    if (char.IsDigit(engineInfo[2], 0))
                    {
                        currEngine.Displacement = engineInfo[2];
                    }
                    else
                    {
                        currEngine.Efficiency = engineInfo[2];
                    }
                }

                if (engineInfo.Length == 4)
                {
                    currEngine.Efficiency = engineInfo[3];
                }

                engines.Add(engineInfo[0], currEngine);
            }

            int m = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInfo[0];
                string engineModel = carInfo[1];
                Car currCar = new Car(carModel, engines[engineModel]);

                if (carInfo.Length >= 3)
                {
                    if (char.IsDigit(carInfo[2], 0))
                    {
                        currCar.Weight = carInfo[2];
                    }
                    else
                    {
                        currCar.Color = carInfo[2];
                    }
                }

                if (carInfo.Length == 4)
                {
                    currCar.Color = carInfo[3];
                }

                cars.Add(currCar);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
