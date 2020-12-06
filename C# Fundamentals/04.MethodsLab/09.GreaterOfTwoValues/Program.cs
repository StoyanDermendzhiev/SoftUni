using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            GetMax(type, value1, value2);
        }

        private static void GetMax(string type, string value1, string value2)
        {
            switch (type)
            {
                case "int":
                    if (int.Parse(value1) > int.Parse(value2))
                    {
                        Console.WriteLine(value1);
                    }
                    else if (int.Parse(value1) < int.Parse(value2))
                    {
                        Console.WriteLine(value2);
                    }
                    break;
                case "char":
                    if (char.Parse(value1) > char.Parse(value2))
                    {
                        Console.WriteLine(value1);
                    }
                    else if (char.Parse(value1) < char.Parse(value2))
                    {
                        Console.WriteLine(value2);
                    }
                    break;
                case "string":
                    if (value1[0] > value2[0])
                    {
                        Console.WriteLine(value1);
                    }
                    else if (value2[0] > value1[0])
                    {
                        Console.WriteLine(value2);
                    }
                    break;
            }
        }
    }
}
