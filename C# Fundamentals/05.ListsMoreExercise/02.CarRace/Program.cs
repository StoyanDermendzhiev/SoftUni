using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> racerTimes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int finishLine = racerTimes.Count / 2;
            double leftRacerTime = 0;

            for (int i = 0; i < finishLine; i++)
            {
                leftRacerTime += racerTimes[i];

                if (racerTimes[i] == 0)
                {
                    leftRacerTime *= 0.8;
                }
            }

            double rightRacerTime = 0;

            for (int i = racerTimes.Count - 1; i > finishLine; i--)
            {
                rightRacerTime += racerTimes[i];

                if (racerTimes[i] == 0)
                {
                    rightRacerTime *= 0.8;
                }
            }

            string winner = string.Empty;
            double winnerTime = 0;

            if (leftRacerTime > rightRacerTime)
            {
                winner = "right";
                winnerTime = rightRacerTime;
            }
            else if (leftRacerTime < rightRacerTime)
            {
                winner = "left";
                winnerTime = leftRacerTime;
            }

            Console.WriteLine($"The winner is {winner} with total time: {winnerTime}");
        }
    }
}
