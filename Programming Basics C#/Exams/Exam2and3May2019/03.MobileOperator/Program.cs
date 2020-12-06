using System;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractPeriod = Console.ReadLine();
            string contractType = Console.ReadLine();
            string mobileNet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double contractPrice = 0;
            int contractYears = 0;

            if (contractPeriod == "one")
            {
                switch (contractType)
                {
                    case "Small":
                        contractPrice = 9.98;
                        break;
                    case "Middle":
                        contractPrice = 18.99;
                        break;
                    case "Large":
                        contractPrice = 25.98;
                        break;
                    case "ExtraLarge":
                        contractPrice = 35.99;
                        break;
                }
            }
            else if (contractPeriod == "two")
            {
                contractYears = 2;
                switch (contractType)
                {
                    case "Small":
                        contractPrice = 8.58;
                        break;
                    case "Middle":
                        contractPrice = 17.09;
                        break;
                    case "Large":
                        contractPrice = 23.59;
                        break;
                    case "ExtraLarge":
                        contractPrice = 31.79;
                        break;
                }
            }
            double totalMoney = months * contractPrice;
            if (mobileNet == "yes")
            {
                if (contractPrice <= 10)
                {
                    totalMoney += months * 5.50;
                }
                else if (contractPrice > 10 && contractPrice <= 30)
                {
                    totalMoney += months * 4.35;
                }
                else
                {
                    totalMoney += months * 3.85;
                }
            }
            if (contractYears == 2)
            {
                totalMoney = totalMoney - totalMoney * 0.0375;
            }
            Console.WriteLine($"{totalMoney:f2} lv.");
        }
    }
}
