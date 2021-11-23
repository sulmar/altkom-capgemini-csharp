using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{

    // LINQ

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

            //List<Product> filteredProducts = new List<Product>();

            //foreach (var product in products)
            //{
            //    if (Filter(product))
            //    {
            //        filteredProducts.Add(product);
            //    }
            //}

            // Linq (Language Integrated Query) - korzysta z wyrażeń lambda: x => x > 2; 
            List<Product> filteredProducts = products
                .Where(product => product.Color == "Blue")
                .OrderByDescending(product => product.UnitPrice)
                .Take(3)
                .ToList();

            // FindAll - to nie jest Linq i występuje tylko na List<T>
            // List<Product> filteredProducts = products.FindAll(product => product.Color == "Blue").ToList();


            // EF (Entity Framework)
            // SQL:
            // SELECT TOP(3) Name, Color, UnitPrice FROM dbo.Products as product
            // WHERE product.Color = 'Blue'
            // ORDER BY product.UnitPrice

            List<Product> filteredProducts1 = (from product in products
                                               where product.Color == "Blue"
                                               orderby product.UnitPrice descending
                                               select product)
                                               .Take(3)
                                               .ToList();

            // 3. Wyświetl pobrane produkty
            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Name= {product.Name}, Color= {product.Color}, UnitPrice= {product.UnitPrice}");
            }

            // Czy istnieje jakikolwiek produkt w kolorze czerwonym?

            // bool hasRedColor = HasColor(products, "Red");

            bool hasRedColor = products.Where(product => product.Color == "Red").Any();

            bool hasRedColor2 = products.Any(product => product.Color == "Red");

            // Czy wszystkie produkty są w kolorze czerwonym?
            bool isAllRedColors = products.All(product => product.Color == "Red");

            // Ile jest produktów poszczególnych kolorów?  
            var query = products
                .GroupBy(product => product.Color)
                .Select(group => new { Kolor = group.Key, Ilosc = group.Count() }) // Typ anonimowy
                .ToList();


            // IEnumerable
            byte[] numbers = new byte[] { 10, 65, 76, 56, 23, 6 };

            var happyNumbers = numbers.Where(number => number > 10);

            IEnumerable<Product> basket = products;


            
            
            

            // SQL:
            // SELECT Color as Kolor, count(*) as Ilosc 
            // GROUP BY Color

        }

        public static bool HasColor(List<Product> products, string color)
        {
            foreach (var product in products)
            {
                if (product.Color == color)     // Predykat
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Filter(Product product)
        {
            return product.Color == "Blue";
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
