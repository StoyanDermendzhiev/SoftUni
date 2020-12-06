using System;

namespace _01.SpringVacationTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTheTrip = int.Parse(Console.ReadLine());
            double budget = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double fuelPricePerKilometer = double.Parse(Console.ReadLine());
            double foodPricePerPersonForDay = double.Parse(Console.ReadLine());
            double roomPricePerPersonForNight = double.Parse(Console.ReadLine());

            double expensesForTravelling = 0.0;

            double totalHotelExpenses = roomPricePerPersonForNight * people * daysOfTheTrip;
            double totalFoodExpenses = foodPricePerPersonForDay * people * daysOfTheTrip;

            if (people > 10)
            {
                totalHotelExpenses *= 0.75;
            }

            double totalExpenses = totalHotelExpenses + totalFoodExpenses;
            
            for (int day = 1; day <= daysOfTheTrip; day++)
            {
                double travelledDistance = double.Parse(Console.ReadLine());
                expensesForTravelling = travelledDistance * fuelPricePerKilometer;
                totalExpenses += expensesForTravelling;

                if (day % 3 == 0 || day % 5 == 0)
                {
                    totalExpenses += totalExpenses * 0.4;
                }

                if (day % 7 == 0)
                {
                    totalExpenses -= totalExpenses / people;
                }

                if (totalExpenses > budget)
                {
                    double moneyNeeded = totalExpenses - budget;
                    Console.WriteLine($"Not enough money to continue the trip. You need {moneyNeeded:f2}$ more.");
                    return;
                }
            }

            double moneyLeft = budget - totalExpenses;

            Console.WriteLine($"You have reached the destination. You have {moneyLeft:f2}$ budget left.");
        }
    }
}
