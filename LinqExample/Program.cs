using System;
using System.Collections.Generic;

namespace LinqExample
{
    class Program
    {
        // TODO:
        // Utwórz listę produktów
        // Produkt posiada atrybuty Name, Color i UnitPrice
        // a następnie pobierz listę produktów w kolorze Blue

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 1. Utwórz listę produktów
            List<Product> products = new List<Product>
            {
                new Product("name1", "Red", 4),
                new Product("name2", "Yellow", 67),
                new Product("name3", "Blue", 46),
                new Product("name4", "Blue", 115),
                new Product("name5", "Red", 80)
            };

            // 2. Pobierz tylko niebieskie produkty
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.Color == "Blue")
                {
                    filteredProducts.Add(product);
                }
            }

            // 3. Wyświetl pobrane produkty
            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Name= {product.Name}, Color= {product.Color}, UnitPrice= {product.UnitPrice}");
            }

        }

    }

  

    public class Product
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal UnitPrice { get; set; }

        public Product(string name, string color, decimal unitPrice)
        {
            Name = name;
            Color = color;
            UnitPrice = unitPrice;
        }
    }
}
