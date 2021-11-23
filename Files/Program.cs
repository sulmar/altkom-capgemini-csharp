using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filename = "products.csv";

            if (File.Exists(filename))
            {
                string content = File.ReadAllText(filename);

              //  Console.WriteLine(content);

                string[] lines = File.ReadAllLines(filename);

                List<Product> products = new List<Product>();

                foreach (var line in lines.Skip(1))
                {
                    string[] columns = line.Split(';');

                    string productName = columns[0];
                    decimal unitPrice = decimal.Parse(columns[1]);
                    int.TryParse(columns[2], out int discount);
                    
                    Product product = new Product
                    {
                        Name = productName,
                        UnitPrice = unitPrice,
                        Discount = discount
                    };

                    products.Add(product);
                    
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Plik {filename} nie istnieje.");
                Console.ResetColor();
            }
        }
    }

    class Product
    {
        // snippet: prop + 2 x Tab
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int? Discount { get; set; }
    }
}
