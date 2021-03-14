using System;

namespace VehiclesExtension
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity, double airConditionConsumption)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            AirConditionConsumption = airConditionConsumption;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            protected set
            {
                if (value > TankCapacity)
                {
                    value = 0;
                }

                fuelQuantity = value;
            }
        }

        public double FuelConsumptionPerKm { get; private set; }

        public double TankCapacity { get; private set; }

        private double AirConditionConsumption { get; set; }
        
        public void Drive(double distance)
        {
            double neededFuel = distance * (FuelConsumptionPerKm + AirConditionConsumption);

            if (neededFuel > FuelQuantity)
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }

            FuelQuantity -= neededFuel;
        }

        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (FuelQuantity + amount > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }

            FuelQuantity += amount;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
