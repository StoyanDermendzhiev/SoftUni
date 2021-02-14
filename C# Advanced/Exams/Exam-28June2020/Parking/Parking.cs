using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> cars;

        public Parking(string type, int capacity)
        {
            cars = new List<Car>();
            Type = type;
            Capacity = capacity;
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count => cars.Count;

        public void Add(Car car)
        {
            if (cars.Count < Capacity)
            {
                cars.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car carToRemove = cars.FindAll(c => c.Manufacturer == manufacturer).Find(c => c.Model == model);

            if (carToRemove != null)
            {
                cars.Remove(carToRemove);
                return true;
            }

            return false;
        }

        public Car GetLatestCar()
        {
            return cars.OrderByDescending(c => c.Year).FirstOrDefault();
        }

        public Car GetCar(string manufacturer, string model)
        {
            return cars.FindAll(c => c.Manufacturer == manufacturer).Find(c => c.Model == model);
        }

        public string GetStatistics()
        {
            return $"The cars are parked in {Type}:{Environment.NewLine}" +
                   $"{string.Join(Environment.NewLine, cars)}";
        }
    }
}
