using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            cars = new List<Car>();
            this.capacity = capacity;
        }

        public int Count => cars.Count;

        public string AddCar(Car car)
        {
            if (cars.Exists(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (cars.Count >= capacity)
            {
                return "Parking is full!";
            }
            else
            {
                cars.Add(car);

                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            Car currCar = cars.Find(c => c.RegistrationNumber == registrationNumber);

            if (currCar != null)
            {
                cars.Remove(currCar);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber) =>
               cars.Find(c => c.RegistrationNumber == registrationNumber);

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string regNumber in registrationNumbers)
            {
                Car currCar = cars.Find(c => c.RegistrationNumber == regNumber);

                if (currCar != null)
                {
                    cars.Remove(currCar);
                }
            }
        }
    }
}
