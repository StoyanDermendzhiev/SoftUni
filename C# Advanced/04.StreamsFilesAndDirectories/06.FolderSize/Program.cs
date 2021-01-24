using System;
using System.IO;

namespace _06.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("../../../TestFolder");

            double fileSizesSum = 0;

            foreach (var filePath in files)
            {
                FileInfo file = new FileInfo(filePath);
                fileSizesSum += file.Length;
            }

            fileSizesSum = fileSizesSum / 1024 / 1024;

            File.WriteAllText("../../../Output.txt", fileSizesSum.ToString());
        }
    }
}
