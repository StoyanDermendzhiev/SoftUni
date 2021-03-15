using System;

namespace _1.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
