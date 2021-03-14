using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle car = createVehicle();
            Vehicle truck = createVehicle();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandInfo = Console.ReadLine().Split();
                string command = commandInfo[0];
                string type = commandInfo[1];
                double parameter = double.Parse(commandInfo[2]);

                if (command == "Drive")
                {
                    try
                    {
                        if (type == nameof(Car))
                        {
                            car.Drive(parameter);
                        }
                        else if (type == nameof(Truck))
                        {
                            truck.Drive(parameter);
                        }

                        Console.WriteLine($"{type} travelled {parameter} km");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (command == "Refuel")
                {
                    if (type == nameof(Car))
                    {
                        car.Refuel(parameter);
                    }
                    else if (type == nameof(Truck))
                    {
                        truck.Refuel(parameter);
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }

        private static Vehicle createVehicle()
        {
            string[] info = Console.ReadLine().Split();
            string type = info[0];

            Vehicle vehicle = null;

            if (type == nameof(Car))
            {
                vehicle = new Car(double.Parse(info[1]),
                    double.Parse(info[2]));
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(double.Parse(info[1]),
                    double.Parse(info[2]));
            }

            return vehicle;
        }
    }
}
