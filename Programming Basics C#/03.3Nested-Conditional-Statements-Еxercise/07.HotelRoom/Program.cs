using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            //Calculations
            double studioPrice = 0;
            double apartmentPrice = 0;
            double totalMoneyForStudio = 0;
            double totalMoneyForApartment = 0;
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;
            }
            if ((nights > 7 && nights <= 14) && (month == "May" || month == "October"))
            {
                totalMoneyForStudio = nights * studioPrice - nights * studioPrice * 0.05;
            }
            else if (nights > 14 && (month == "May" || month == "October"))
            {
                totalMoneyForStudio = nights * studioPrice - nights * studioPrice * 0.3;
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                totalMoneyForStudio = nights * studioPrice - nights * studioPrice * 0.2;
            }
            else
            {
                totalMoneyForStudio = nights * studioPrice;
            }
            if (nights > 14)
            {
                totalMoneyForApartment = nights * apartmentPrice - nights * apartmentPrice * 0.1;
            }
            else
            {
                totalMoneyForApartment = nights * apartmentPrice;
            }
            Console.WriteLine($"Apartment: {totalMoneyForApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalMoneyForStudio:f2} lv.");
        }
    }
}
