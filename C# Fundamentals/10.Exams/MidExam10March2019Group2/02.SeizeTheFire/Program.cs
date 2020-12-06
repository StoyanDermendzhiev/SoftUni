using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                    .Split("#")
                                    .ToList();
            int amountOfWater = int.Parse(Console.ReadLine());

            List<string> typeOfFire = new List<string>(input.Count - 1);
            List<int> valueOfCells = new List<int>(input.Count - 1);

            foreach (string item in input)
            {
                string element = item;
                string[] elements = element.Split(" = ")
                                           .ToArray();

                typeOfFire.Add(elements[0]);
                valueOfCells.Add(int.Parse(elements[1]));
            }

            List<int> putOutCells = new List<int>();
            int totalFire = 0;
            double totalEffort = 0;

            for (int i = 0; i < typeOfFire.Count; i++)
            {
                string currentTypeOfFire = typeOfFire[i];
                int currentValuewOfCell = valueOfCells[i];

                if (amountOfWater >= currentValuewOfCell)
                {
                    switch (currentTypeOfFire)
                    {
                        case "High":
                            if (!(currentValuewOfCell >= 81 && currentValuewOfCell <= 125))
                            {
                                continue;
                            }
                            break;
                        case "Medium":
                            if (!(currentValuewOfCell >= 51 && currentValuewOfCell <= 80))
                            {
                                continue;
                            }
                            break;
                        case "Low":
                            if (!(currentValuewOfCell >= 1 && currentValuewOfCell <= 50))
                            {
                                continue;
                            }
                            break;
                    }
                    amountOfWater -= currentValuewOfCell;
                    totalFire += currentValuewOfCell;
                    totalEffort += 0.25 * currentValuewOfCell;
                    putOutCells.Add(currentValuewOfCell);
                }
            }

            Console.WriteLine("Cells:");

            foreach (int cell in putOutCells)
            {
                Console.WriteLine($" - {cell}");
            }

            Console.WriteLine($"Effort: {totalEffort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
