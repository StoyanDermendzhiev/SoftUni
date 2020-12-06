using System;

namespace _04.EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggNumberPlayer1 = int.Parse(Console.ReadLine());
            int eggNumberPlayer2 = int.Parse(Console.ReadLine());
            int totalEggNumber = eggNumberPlayer1 + eggNumberPlayer2;
            for (int i = 1; i <= totalEggNumber; i++)
            {
                string playerWin = Console.ReadLine();
                if (playerWin == "one")
                {
                    eggNumberPlayer2 -= 1;
                    if (eggNumberPlayer2 == 0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {eggNumberPlayer1} eggs left.");
                        break;
                    }
                }
                else if (playerWin == "two")
                {
                    eggNumberPlayer1 -= 1;
                    if (eggNumberPlayer1 == 0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {eggNumberPlayer2} eggs left.");
                        break;
                    }
                }
                else if (playerWin == "End of battle")
                {
                    Console.WriteLine($"Player one has {eggNumberPlayer1} eggs left.");
                    Console.WriteLine($"Player two has {eggNumberPlayer2} eggs left.");
                    break;
                }
            }
        }
    }
}
