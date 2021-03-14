namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConditionerConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm) 
            : base(fuelQuantity, fuelConsumptionPerKm + airConditionerConsumption)
        { }

        public override void Refuel(double amount)
        {
            base.Refuel(amount * 0.95);
        }
    }
}
