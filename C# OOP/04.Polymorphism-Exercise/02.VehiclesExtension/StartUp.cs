using System;

namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle car = createVehicle();
            Vehicle truck = createVehicle();
            Vehicle bus = createVehicle();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandInfo = Console.ReadLine().Split();
                string command = commandInfo[0];
                string type = commandInfo[1];
                double parameter = double.Parse(commandInfo[2]);

                try
                {
                    if (type == nameof(Car))
                    {
                        ProcessCommand(car, command, parameter);
                    }
                    else if (type == nameof(Truck))
                    {
                        ProcessCommand(truck, command, parameter);
                    }
                    else if (type == nameof(Bus))
                    {
                        ProcessCommand(bus, command, parameter);
                    }
                }
                catch (Exception ex)
                    when (ex is InvalidOperationException || ex is ArgumentException)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }

        private static void ProcessCommand(Vehicle vehicle, string command, double parameter)
        {
            if (command == "Drive")
            {
                vehicle.Drive(parameter);

                Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
            }
            else if (command == "DriveEmpty")
            {
                ((Bus)vehicle).DriveEmpty(parameter);

                Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
            }
            else
            {
                vehicle.Refuel(parameter);
            }
        }

        private static Vehicle createVehicle()
        {
            string[] info = Console.ReadLine().Split();
            string type = info[0];
            double fuelQuantity = double.Parse(info[1]);
            double fuelConsumption = double.Parse(info[2]);
            double tankCapacity = double.Parse(info[3]);

            Vehicle vehicle = null;

            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }

            return vehicle;
        }
    }
}
