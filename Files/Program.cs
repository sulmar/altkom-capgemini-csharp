using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Files
{
    class Program
    {
        private static Product Map(string line)
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

            return product;
        }

        private static string Map(Product product)
        {
            string line = $"{product.Name};{product.UnitPrice};{product.Discount}";

            return line;
        }


        static void Main(string[] args)
        {
            const string filename = "products2.csv";

         

            if (File.Exists(filename))
            {
                string content = File.ReadAllText(filename);

              //  Console.WriteLine(content);

                string[] lines = File.ReadAllLines(filename);

               // List<Product> products = new List<Product>();

                //foreach (var line in lines.Skip(1))
                //{
                //    Product product = Map(line);
                //    products.Add(product);                    
                //}

                //foreach (var line in lines.Skip(1))
                //{
                //    products.Add(Map(line));
                //}

                // Linq
                var products = lines
                    .Skip(1)
                    .Select(line => Map(line)) // Map
                    .ToList();

                foreach (var item in products)
                {
                    Console.WriteLine(item);
                }

                Product newProduct = new Product { Name = "Selenium", UnitPrice = 1000, Discount = 50 };

                products.Add(newProduct);


                List<string> outputLines = new List<string>();

                outputLines.Add("Name;UnitPrice;Discount");

                foreach (var product in products)
                {
                    //string line = $"{product.Name};{product.UnitPrice};{product.Discount}";

                    //outputLines.Add(line);

                    outputLines.Add(Map(product));
                }

                // Linq
                // outputLines = products.Select(product => Map(product)).ToList();

                File.AppendAllLines("output.csv", outputLines);


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


        public override string ToString()
        {
            return $"{Name} {UnitPrice:C2} {Discount}%";
        }
    }
}
