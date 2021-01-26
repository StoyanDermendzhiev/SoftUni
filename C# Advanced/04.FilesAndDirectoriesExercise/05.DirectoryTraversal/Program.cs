using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles(Directory.GetCurrentDirectory());

            Dictionary<string, Dictionary<string, double>> filesData = new Dictionary<string, Dictionary<string, double>>();

            foreach (string fullFileName in fileNames)
            {
                FileInfo fileInfo = new FileInfo(fullFileName);
                string extension = fileInfo.Extension;
                long size = fileInfo.Length;
                double kbSize = Math.Round(size / 1024.0, 3);

                if (!filesData.ContainsKey(extension))
                {
                    filesData.Add(extension, new Dictionary<string, double>());
                }

                filesData[extension].Add(fileInfo.Name, kbSize);
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter writer = new StreamWriter($"{path}/report.txt"))
            {
                foreach (var extension in filesData.OrderByDescending(e => e.Value.Count)
                                                   .ThenBy(e=>e.Key))
                {
                    writer.WriteLine(extension.Key);

                    foreach (var fileInfo in extension.Value.OrderBy(f=>f.Value))
                    {
                        writer.WriteLine($"--{fileInfo.Key} - {fileInfo.Value}kb");
                    }
                }
            }
        }
    }
}
