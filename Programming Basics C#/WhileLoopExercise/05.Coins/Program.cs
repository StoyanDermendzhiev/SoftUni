using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            change *= 100;
            int changeInCoins = (int)change;
            int coins = 0;
            while (changeInCoins > 0)
            {
                if (changeInCoins - 200 >= 0)
                {
                    coins++;
                    changeInCoins -= 200;
                }
                else if (changeInCoins - 100 >= 0)
                {
                    coins++;
                    changeInCoins -= 100;
                }
                else if (changeInCoins - 50 >= 0)
                {
                    coins++;
                    changeInCoins -= 50;
                }
                else if (changeInCoins - 20 >= 0)
                {
                    coins++;
                    changeInCoins -= 20;
                }
                else if (changeInCoins - 10 >= 0)
                {
                    coins++;
                    changeInCoins -= 10;
                }
                else if (changeInCoins - 5 >= 0)
                {
                    coins++;
                    changeInCoins -= 5;
                }
                else if (changeInCoins - 2 >= 0)
                {
                    coins++;
                    changeInCoins -= 2;
                }
                else if (changeInCoins - 1 >= 0)
                {
                    coins++;
                    changeInCoins -= 1;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
