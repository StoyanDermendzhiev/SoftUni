using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string input = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    GetIntResult(input);
                    break;
                case "real":
                    GetDoubleResult(input);
                    break;
                case "string":
                    GetStringResult(input);
                    break;
            }
        }

        private static void GetStringResult(string input)
        {
            Console.WriteLine("$" + input + "$");
        }

        private static void GetDoubleResult(string input)
        {
            double output = double.Parse(input) * 1.5;

            Console.WriteLine($"{output:f2}");
        }

        private static void GetIntResult(string input)
        {
            int output = int.Parse(input) * 2;

            Console.WriteLine(output);
        }
    }
}
