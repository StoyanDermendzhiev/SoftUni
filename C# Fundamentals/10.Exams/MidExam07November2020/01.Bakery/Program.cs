using System;

namespace _01.Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsAmountPerWorkerForDay = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int competingFactoryBiscuits = int.Parse(Console.ReadLine());

            int biscuitsProductionPerDay = biscuitsAmountPerWorkerForDay * workersCount;
            double biscuitProductionThirdDay = Math.Floor(biscuitsProductionPerDay * 0.75);

            int days = 30;
            int myFactoryBiscuits = 0;

            for (int day = 1; day <= days; day++)
            {
                if (day % 3 == 0)
                {
                    myFactoryBiscuits += (int)biscuitProductionThirdDay;
                }
                else
                {
                    myFactoryBiscuits += biscuitsProductionPerDay;
                }
            }

            Console.WriteLine($"You have produced {myFactoryBiscuits} biscuits for the past month.");

            double difference = 0;

            if (myFactoryBiscuits > competingFactoryBiscuits)
            {
                difference = myFactoryBiscuits - competingFactoryBiscuits;
                double moreBiscuitsPercent = difference / competingFactoryBiscuits * 100;
                Console.WriteLine($"You produce {moreBiscuitsPercent:f2} percent more biscuits.");
            }
            else if (myFactoryBiscuits < competingFactoryBiscuits)
            {
                difference = competingFactoryBiscuits - myFactoryBiscuits;
                double lessBiscuitsPercent = difference / competingFactoryBiscuits * 100;
                Console.WriteLine($"You produce {lessBiscuitsPercent:f2} percent less biscuits.");
            }
        }
    }
}
