using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string dataType = string.Empty;
            int valueInt;
            double valueDouble;
            char valueChar;
            bool valueBool;

            while (input != "END")
            {

            if (int.TryParse(input, out valueInt))
            {
                dataType = "integer";
            }
            else if (double.TryParse(input, out valueDouble))
            {
                dataType = "floating point";
            }
            else if (char.TryParse(input, out valueChar))
            {
                dataType = "character";
            }
            else if (bool.TryParse(input, out valueBool))
            {
                dataType = "boolean";
            }
            else
            {
                dataType = "string";
            }
                Console.WriteLine($"{input} is {dataType} type");
                input = Console.ReadLine();
            }

        }
    }
}
