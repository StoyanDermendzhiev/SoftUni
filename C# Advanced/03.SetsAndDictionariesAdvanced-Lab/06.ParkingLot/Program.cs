using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> cars = new HashSet<string>();

            while (input != "END")
            {
                string[] carInfo = input.Split(", ");
                string command = carInfo[0];
                string carNumber = carInfo[1];

                if (command == "IN")
                {
                    cars.Add(carNumber);
                }
                else if (command == "OUT")
                {
                    cars.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
