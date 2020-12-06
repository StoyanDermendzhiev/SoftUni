using System;

namespace _01.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double racketPrice = double.Parse(Console.ReadLine());
            int racketNumber = int.Parse(Console.ReadLine());
            int sneakersNumber = int.Parse(Console.ReadLine());

            double sneakersPrice = racketPrice / 6;
            double accessoriesPrice = (racketPrice * racketNumber + sneakersPrice * sneakersNumber) * 0.20;
            double totalMoney = racketPrice * racketNumber + sneakersPrice * sneakersNumber + accessoriesPrice;
            double moneyPaidByDjokovic = totalMoney / 8;
            double moneyPaidBySponsors = totalMoney - moneyPaidByDjokovic;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(moneyPaidByDjokovic)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(moneyPaidBySponsors)}");
        }
    }
}
