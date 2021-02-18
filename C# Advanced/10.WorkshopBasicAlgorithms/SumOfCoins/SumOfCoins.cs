using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        string[] coinsInfo = Console.ReadLine()
            .Split(new char[] { ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] availableCoins = coinsInfo.Skip(1).Select(int.Parse).ToArray();

        string[] targetSumInfo = Console.ReadLine().Split();
        int targetSum = int.Parse(targetSumInfo[1]);

        try
        {
            var selectedCoins = ChooseCoins(availableCoins, targetSum);

            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
            foreach (var selectedCoin in selectedCoins)
            {
                Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        coins = coins.OrderByDescending(c => c).ToList();

        Dictionary<int, int> choosenCoins = new Dictionary<int, int>();
        int currentSum = 0;
        int currentCoinIndex = 0;

        while (currentSum < targetSum && currentCoinIndex < coins.Count)
        {
            int currentCoinNumber = (targetSum - currentSum) / coins[currentCoinIndex];

            if (currentCoinNumber != 0)
            {
                choosenCoins.Add(coins[currentCoinIndex], currentCoinNumber);
                currentSum += currentCoinNumber * coins[currentCoinIndex];
            }

            currentCoinIndex++;
        }

        if (currentSum != targetSum)
        {
            throw new Exception("Error");
        }

        return choosenCoins;
    }
}