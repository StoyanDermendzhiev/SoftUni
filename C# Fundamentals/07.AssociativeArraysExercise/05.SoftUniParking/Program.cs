using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingLot = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();

                string currentCommand = command[0];
                string userName = command[1];

                if (currentCommand == "register")
                {
                    string licensePlateNumber = command[2];

                    if (parkingLot.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingLot[userName]}");
                    }
                    else
                    {
                        parkingLot.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                }
                else if (currentCommand == "unregister")
                {
                    if (parkingLot.ContainsKey(userName))
                    {
                        parkingLot.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
            }

            foreach (var currentUser in parkingLot)
            {
                Console.WriteLine($"{currentUser.Key} => {currentUser.Value}");
            }
        }
    }
}
