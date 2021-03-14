using System;
using System.ComponentModel;

namespace Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumptionPerKm { get; private set; }

        public void Drive(double distance)
        {
            double neededFuel = distance * FuelConsumptionPerKm;

            if (neededFuel > FuelQuantity)
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }

            FuelQuantity -= neededFuel;
        }

        public virtual void Refuel(double amount)
        {
            FuelQuantity += amount;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
