using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string productName = "Cola";
            decimal productUnitPrice = 5.99m;
            float productCapacity = 1.5f;
            string barcode = "443242342342";

            string productName2 = "Woda mineralna";
            decimal productUnitPrice2 = 1.99m;
            float productCapacity2 = 0.5f;
            string barcode2 = "999999999";

            string productName3 = "Paluszki";
            decimal productUnitPrice3 = 1.99m;
            float productWeight3 = 1.5f;
            float? productCapacity3;

            PrintProduct(productName, productUnitPrice, productCapacity);
            PrintProduct(productName2, productUnitPrice2, productCapacity2);

            // Programowanie obiektowe (OOP Object Oriented Programming = Programowanie zorientowane obiektowo)

            Product product1 = new Product();   // utworzenie instacji klasy - powstaje obiekt (object)
            product1.name = "Cola";
            product1.unitPrice = 5.99m;
            product1.capacity = 1.5f;
            product1.Print();          

            Product product2 = new Product();
            product2.name = "Woda mineralna";
            product2.unitPrice = 1.99m;
            product2.capacity = 0.5f;
            product2.Print();

            Product product3 = new Product();
            product3.name = "Paluszki";
            product3.unitPrice = 1.99m;
            product3.weight = 1.5f;

            product3.Print();

        }

        public static void PrintProduct(string name, decimal unitPrice, float capacity)
        {
            // C2 - formatowanie 100,99 zł
            Console.WriteLine($"> {name} {unitPrice:C2} {capacity}L");
        }

        public static void PrintPerson(string firstName, string lastName)
        {
            Console.WriteLine($"> {firstName} {lastName}");
        }
    }

    class Product
    {
        // cechy (atrybute/pola)
        public string name;
        public decimal unitPrice;
        public float? capacity; // nullable
        public float weight;

        // czynności (metody), które operują na tych cechach
        public void Print()
        {
            if (capacity.HasValue)  // sprawdza czy pole ma wartość null
            {
                Console.WriteLine($"> {name} {unitPrice:C2} {weight} kg {capacity}L");
            }
            else
            {
                Console.WriteLine($"> {name} {unitPrice:C2} {weight} kg" );
            }
        }

        public decimal GetPriceFor1kg()
        {
            if (capacity.HasValue)
            {
                return unitPrice / (decimal) capacity;               
            }
            else
            {
                return unitPrice / (decimal) weight;
            }
        }
    }

    class Person
    {
        public string firstName;
        public string lastName;
        private string pesel;

        public void Print()
        {
            Console.WriteLine($"{firstName} {lastName}");
        }

        public void DoUnitTest()
        {
            Console.WriteLine($"Testing by {firstName}...");
        }
    }
}
