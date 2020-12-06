using System;

namespace _05.FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            int backCount = 0;
            int chestCount = 0;
            int legsCount = 0;
            int absCount = 0;
            int shakeCount = 0;
            int barCount = 0;

            for (int i = 1; i <= clients; i++)
            {
                string activity = Console.ReadLine();
                switch (activity)
                {
                    case "Back":
                        backCount++;
                        break;
                    case "Chest":
                        chestCount++;
                        break;
                    case "Legs":
                        legsCount++;
                        break;
                    case "Abs":
                        absCount++;
                        break;
                    case "Protein shake":
                        shakeCount++;
                        break;
                    case "Protein bar":
                        barCount++;
                        break;
                }
            }
            double percentWorkOut = 1.0 * (backCount + chestCount + legsCount + absCount) / clients * 100;
            double percentProtein = 100 - percentWorkOut;

            Console.WriteLine($"{backCount} - back");
            Console.WriteLine($"{chestCount} - chest");
            Console.WriteLine($"{legsCount} - legs");
            Console.WriteLine($"{absCount} - abs");
            Console.WriteLine($"{shakeCount} - protein shake");
            Console.WriteLine($"{barCount} - protein bar");
            Console.WriteLine($"{percentWorkOut:f2}% - work out");
            Console.WriteLine($"{percentProtein:f2}% - protein");
        }
    }
}
