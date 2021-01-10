using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            var stack = new Stack<int>(clothes.Reverse());
            int sum = 0;
            int racks = 0;
            
            while (stack.Count > 0)
            {
                int pieceOfClothing = stack.Pop();
                sum += pieceOfClothing;

                if (sum == rackCapacity)
                {
                    racks++;
                    sum = 0;
                }
                else if (sum > rackCapacity)
                {
                    racks++;
                    sum = pieceOfClothing;
                }
            }

            if (sum > 0)
            {
                racks++;
            }

            Console.WriteLine(racks);

        }
    }
}
