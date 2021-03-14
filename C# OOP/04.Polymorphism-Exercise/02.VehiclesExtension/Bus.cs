using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        private const double airConditionConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity, airConditionConsumption)
        {
        }

        public void DriveEmpty(double distance)
        {
            double neededFuel = distance * FuelConsumptionPerKm;

            if (neededFuel > FuelQuantity)
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }

            FuelQuantity -= neededFuel;
        }
    }
}
