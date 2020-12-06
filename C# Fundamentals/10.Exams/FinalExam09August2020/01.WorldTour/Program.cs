using System;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Travel")
            {
                var command = input.Split(":");
                string currentCommand = command[0];

                if (currentCommand == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string stop = command[2];

                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, stop);
                    }
                }
                else if (currentCommand == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    bool isValidIndexes = startIndex >= 0 &&
                                          startIndex <= endIndex &&
                                          endIndex < stops.Length;

                    if (isValidIndexes)
                    {
                        int count = endIndex - startIndex + 1;
                        stops = stops.Remove(startIndex, count);
                    }
                }
                else if (currentCommand == "Switch")
                {
                    string oldString = command[1];
                    string newString = command[2];

                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                    }
                }

                Console.WriteLine(stops);

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
