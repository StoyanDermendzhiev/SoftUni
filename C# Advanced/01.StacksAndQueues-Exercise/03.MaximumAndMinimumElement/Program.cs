using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            var sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int query = int.Parse(input[0]);

                switch (query)
                {
                    case 1:
                        int x = int.Parse(input[1]);
                        stack.Push(x);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            sb.AppendLine(stack.Max().ToString());
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            sb.AppendLine(stack.Min().ToString());
                        }
                        break;
                }
            }

            while (stack.Count > 1)
            {
                sb.Append($"{stack.Pop()}, ");
            }

            sb.Append(stack.Pop().ToString());

            Console.WriteLine(sb.ToString());
        }
    }
}
