using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Car
    {
        public Car(string carModel)
        {
            CarModel = carModel;
            CarLength = carModel.Length;
        }

        public string CarModel { get; set; }
        public int CarLength { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            var queue = new Queue<Car>();
            int carCount = 0;

            while (input != "END")
            {
                if (input != "green")
                {
                    Car currentCar = new Car(input);
                    queue.Enqueue(currentCar);
                }
                else
                {
                    int currentGreenLight = greenLight;
                    while (currentGreenLight > 0 && queue.Count > 0)
                    {
                        if (currentGreenLight >= queue.Peek().CarLength)
                        {
                            currentGreenLight -= queue.Dequeue().CarLength;
                            carCount++;
                        }
                        else
                        {
                            queue.Peek().CarLength -= currentGreenLight;
                            currentGreenLight = 0;
                        }
                    }

                    if (queue.Count != 0)
                    {
                        if (queue.Peek().CarLength > freeWindow)
                        {
                            string crashedCar = queue.Peek().CarModel;
                            int lengthLeft = queue.Dequeue().CarLength;
                            int crashedIndex = crashedCar.Length - lengthLeft + freeWindow;

                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{crashedCar} was hit at {crashedCar[crashedIndex]}.");
                            return;
                        }
                        else
                        {
                            carCount++;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carCount} total cars passed the crossroads.");
        }
    }
}
