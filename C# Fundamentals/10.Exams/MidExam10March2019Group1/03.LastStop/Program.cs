using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintingNumbers = Console.ReadLine()
                                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                               .Select(int.Parse)
                                               .ToList();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = command[0];

                if (currentCommand == "Change")
                {
                    int paintingNumber = int.Parse(command[1]);
                    int changedNumber = int.Parse(command[2]);

                    if (paintingNumbers.Contains(paintingNumber))
                    {
                        int paintingIndex = paintingNumbers.IndexOf(paintingNumber);
                        paintingNumbers[paintingIndex] = changedNumber;
                    }
                }
                else if (currentCommand == "Hide")
                {
                    int paintingNumber = int.Parse(command[1]);

                    if (paintingNumbers.Contains(paintingNumber))
                    {
                        paintingNumbers.Remove(paintingNumber);
                    }
                }
                else if (currentCommand == "Switch")
                {
                    int paintingNumber = int.Parse(command[1]);
                    int paintingNumber2 = int.Parse(command[2]);

                    if (paintingNumbers.Contains(paintingNumber) && paintingNumbers.Contains(paintingNumber2))
                    {
                        int indexOfPainting = paintingNumbers.IndexOf(paintingNumber);
                        int indexOfPainting2 = paintingNumbers.IndexOf(paintingNumber2);
                        paintingNumbers[indexOfPainting] = paintingNumber2;
                        paintingNumbers[indexOfPainting2] = paintingNumber;
                    }
                }
                else if (currentCommand == "Insert")
                {
                    int place = int.Parse(command[1]);
                    int paintingNumber = int.Parse(command[2]);

                    if (place >= 0 && place < paintingNumbers.Count - 1)
                    {
                        paintingNumbers.Insert(place + 1, paintingNumber);
                    }
                }
                else if (currentCommand == "Reverse")
                {
                    paintingNumbers.Reverse();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", paintingNumbers));
        }
    }
}
