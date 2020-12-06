using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string barcodePattern = @"(@#+)([A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)";
            Regex regex = new Regex(barcodePattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match validBarcode = regex.Match(input);

                if (validBarcode.Success)
                {
                    string productGroup = string.Empty;

                    foreach (char ch in validBarcode.Value.Where(x=>char.IsDigit(x)))
                    {
                        productGroup += ch;
                    }

                    if (productGroup.Count() == 0)
                    {
                        productGroup = "00";
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
                
            }
        }
    }
}
