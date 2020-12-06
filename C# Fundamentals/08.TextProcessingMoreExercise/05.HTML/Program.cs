using System;
using System.Text;

namespace _05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string comment = Console.ReadLine();

            var htmlFormat = new StringBuilder();

            htmlFormat.AppendLine("<h1>");
            htmlFormat.AppendLine($"{title}");
            htmlFormat.AppendLine("</h1>");
            htmlFormat.AppendLine("<article>");
            htmlFormat.AppendLine($"{content}");
            htmlFormat.AppendLine("</article>");

            while (comment != "end of comments")
            {
                htmlFormat.AppendLine("<div>");
                htmlFormat.AppendLine($"{comment}");
                htmlFormat.AppendLine("</div>");

                comment = Console.ReadLine();
            }

            Console.WriteLine(htmlFormat.ToString().Trim());
        }
    }
}
