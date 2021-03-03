using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public static class Valdator
    {
        public static void ThrowIfStringIsNullOrWhiteSpace(string str, string exceptionMessage)
        {
            if (string.IsNullOrWhiteSpace(str) || string.IsNullOrEmpty(str))
            {
                throw new ArgumentException(exceptionMessage);
            }
        }

        public static void ThrowIfNumberIsNotInRange(int number, int min, int max, string exceptionMessage)
        {
            if (number < min || number > max)
            {
                throw new ArgumentException(exceptionMessage);
            }
        }
    }
}
