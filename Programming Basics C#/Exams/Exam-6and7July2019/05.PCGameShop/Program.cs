using System;

namespace _05.PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesSold = int.Parse(Console.ReadLine());

            int hearthstoneCount = 0;
            int forniteCount = 0;
            int overwatchCount = 0;
            int othersCount = 0;

            for (int game = 1; game <= gamesSold; game++)
            {
                string gameName = Console.ReadLine();
                switch (gameName)
                {
                    case "Hearthstone":
                        hearthstoneCount++;
                        break;
                    case "Fornite":
                        forniteCount++;
                        break;
                    case "Overwatch":
                        overwatchCount++;
                        break;
                    default:
                        othersCount++;
                        break;
                }
            }
            double percentHearthstone = 1.0 * hearthstoneCount / gamesSold * 100;
            double percentFornite = 1.0 * forniteCount / gamesSold * 100;
            double percentOverwatch = 1.0 * overwatchCount / gamesSold * 100;
            double percentOthers = 1.0 * othersCount / gamesSold * 100;

            Console.WriteLine($"Hearthstone - {percentHearthstone:f2}%");
            Console.WriteLine($"Fornite - {percentFornite:f2}%");
            Console.WriteLine($"Overwatch - {percentOverwatch:f2}%");
            Console.WriteLine($"Others - {percentOthers:f2}%");
        }
    }
}
