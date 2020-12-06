using System;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string field = Console.ReadLine();

            int bombPower = 0;

            for (int i = 0; i < field.Length; i++)
            {
                if (field[i] == '>')
                {
                    bombPower += int.Parse(field[i+1].ToString());
                    continue;
                }

                if (bombPower > 0)
                {
                    field = field.Remove(i, 1);
                    i--;
                    bombPower--;
                }
            }

            Console.WriteLine(field);
        }
    }
}
