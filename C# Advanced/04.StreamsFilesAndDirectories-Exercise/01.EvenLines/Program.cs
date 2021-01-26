using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string line = reader.ReadLine();
                int counter = 0;

                string pattern = @"[\-,.!?]";
                Regex regex = new Regex(pattern);

                while (line != null)
                {
                    if (counter++ % 2 == 0)
                    {
                        line = regex.Replace(line, "@");
                        string[] words = line.Split();

                        Console.WriteLine(string.Join(" ", words.Reverse()));
                    }

                    line = reader.ReadLine();
                }
            }
        }
    }
}
