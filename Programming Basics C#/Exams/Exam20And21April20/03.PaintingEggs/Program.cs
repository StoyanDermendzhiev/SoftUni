using System;

namespace _03.PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggSize = Console.ReadLine();
            string eggColour = Console.ReadLine();
            int lotNumber = int.Parse(Console.ReadLine());
            int eggLotPrice = 0;
            if (eggSize == "Large")
            {
                switch (eggColour)
                {
                    case "Red":
                        eggLotPrice = 16;
                        break;
                    case "Green":
                        eggLotPrice = 12;
                        break;
                    case "Yellow":
                        eggLotPrice = 9;
                        break;
                }
            }
            else if (eggSize == "Medium")
            {
                switch (eggColour)
                {
                    case "Red":
                        eggLotPrice = 13;
                        break;
                    case "Green":
                        eggLotPrice = 9;
                        break;
                    case "Yellow":
                        eggLotPrice = 7;
                        break;
                }
            }
            else if (eggSize == "Small")
            {
                switch (eggColour)
                {
                    case "Red":
                        eggLotPrice = 9;
                        break;
                    case "Green":
                        eggLotPrice = 8;
                        break;
                    case "Yellow":
                        eggLotPrice = 5;
                        break;
                }
            }
            double totalMoney = lotNumber * eggLotPrice * 0.65;
            Console.WriteLine($"{totalMoney:f2} leva.");
        }
    }
}
