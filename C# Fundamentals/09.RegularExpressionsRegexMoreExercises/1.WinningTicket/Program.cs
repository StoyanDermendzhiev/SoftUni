using System;
using System.Text.RegularExpressions;

namespace _1.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                                      .Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"[\@\#\$\^]{6,}";
            Regex regex = new Regex(pattern);

            foreach (string ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    string rightSide = ticket.Substring(10);
                    string leftSide = ticket.Remove(10);

                    Match matchLeft = regex.Match(leftSide);
                    Match matchRight = regex.Match(rightSide);

                    bool isMatch = matchLeft.Success &&
                                   matchRight.Success;

                    if (isMatch)
                    {
                        string matchSymbol = matchLeft.Value.Substring(0, 1);
                        int minMatch = Math.Min(matchLeft.Value.Length, matchRight.Value.Length);

                        if (minMatch == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {minMatch}{matchSymbol} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {minMatch}{matchSymbol}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
