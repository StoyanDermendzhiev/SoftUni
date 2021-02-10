using System;

namespace _08.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();

            string names = $"{firstInput[0]} {firstInput[1]}";
            string addres = firstInput[2];
            string town = firstInput.Length == 4 ? 
                firstInput[3] : $"{firstInput[3]} {firstInput[4]}";

            Threeuple<string, string, string> first = 
                new Threeuple<string, string, string>(names, addres, town);

            string[] secondInput = Console.ReadLine().Split();

            string name = secondInput[0];
            int beer = int.Parse(secondInput[1]);
            bool drunkOrNot = secondInput[2] == "drunk" ? true : false;

            Threeuple<string, int, bool> second = 
                new Threeuple<string, int, bool>(name, beer, drunkOrNot);

            string[] thirdInput = Console.ReadLine().Split();

            string personName = thirdInput[0];
            double accountBalance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];

            Threeuple<string, double, string> third = 
                new Threeuple<string, double, string>(personName, accountBalance, bankName);

            Console.WriteLine($"{first.Item1} -> {first.Item2} -> {first.Item3}");
            Console.WriteLine($"{second.Item1} -> {second.Item2} -> {second.Item3}");
            Console.WriteLine($"{third.Item1} -> {third.Item2} -> {third.Item3}");
        }
    }
}
