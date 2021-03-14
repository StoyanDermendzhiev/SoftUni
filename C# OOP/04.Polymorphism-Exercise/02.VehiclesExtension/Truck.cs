using System;

namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        private const double airConditionerConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity, airConditionerConsumption)
        { }

        public override void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (FuelQuantity + amount > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }

            FuelQuantity += amount * 0.95;
        }
    }
}
