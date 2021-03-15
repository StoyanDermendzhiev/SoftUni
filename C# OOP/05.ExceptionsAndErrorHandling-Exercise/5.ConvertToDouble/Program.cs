using System;

namespace _5.ConvertToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double result;

            try
            {
                result = Convert.ToDouble(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
