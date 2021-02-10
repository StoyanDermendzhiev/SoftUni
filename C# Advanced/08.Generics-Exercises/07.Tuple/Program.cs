using System;

namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();

            string names = $"{firstInput[0]} {firstInput[1]}";
            string addres = firstInput[2];

            Tuple<string, string> first = new Tuple<string, string>(names, addres);

            string[] secondInput = Console.ReadLine().Split();

            string name = secondInput[0];
            int beer = int.Parse(secondInput[1]);

            Tuple<string, int> second = new Tuple<string, int>(name, beer);

            string[] thirdInput = Console.ReadLine().Split();

            int integerNum = int.Parse(thirdInput[0]);
            double doubleNum = double.Parse(thirdInput[1]);

            Tuple<int, double> third = new Tuple<int, double>(integerNum, doubleNum);

            Console.WriteLine($"{first.Item1} -> {first.Item2}");
            Console.WriteLine($"{second.Item1} -> {second.Item2}");
            Console.WriteLine($"{third.Item1} -> {third.Item2}");
        }
    }
}
