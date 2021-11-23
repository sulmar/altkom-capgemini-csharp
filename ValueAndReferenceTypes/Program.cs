using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Typy wartościowe (proste)");
            // int, byte, float, DateTime, bool, struct

            Location location = new Location(52.05, 18.04);

            Console.WriteLine(location);
            DoWork(ref location);
            Console.WriteLine(location);

            int x = 10;

            DoWork(ref x);

            Console.WriteLine(x);

            int y = x;   // <--- kopia x

            y++;

            Console.WriteLine(x);
            Console.WriteLine(y);


            // Immutable (niezmienny)
            string firstName = "John";

            string secondName = firstName.ToLower();

            secondName = "Adam";

            Console.WriteLine(firstName);
            Console.WriteLine(secondName);

            // x=10, y=11

            Console.WriteLine("Typy referencyjne");

            Person person = new Person { FirstName = "John" };

            Person selectedPerson = person;

            DoWork(person);

            selectedPerson.FirstName = "Adam";

            Console.WriteLine(person.FirstName);
            Console.WriteLine(selectedPerson.FirstName);

            Order oldOrder = new Order { Id = 1, CustomerName = "ABC", OrderDate = DateTime.Parse("2021-11-10"), TotalAmount = 1000 };



            // Utworzyć kopię zamówienia
            // Order newOrder = oldOrder;

            Order newOrder = new Order() // <- new() aby utworzyć nowy obiekt
            {
                Id = oldOrder.Id,
                CustomerName = oldOrder.CustomerName,
                OrderDate = oldOrder.OrderDate,
                TotalAmount = 900
            };


            Order newOrder2 = new Order(oldOrder.Id, oldOrder.OrderDate, oldOrder.TotalAmount, oldOrder.CustomerName)
            {
                TotalAmount = 900
            };

            newOrder.Id = 2;
            newOrder.OrderDate = DateTime.Now;
            newOrder.TotalAmount = 900;

            Console.WriteLine(oldOrder);
            Console.WriteLine(newOrder);

            // Save to Db

        }

        public static void DoWork(ref int x)
        {
            x++;
        }

        public static void DoWork(Person person)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            person.FirstName = person.FirstName.ToUpper();
            Console.WriteLine(person);
            Console.ResetColor();
        }

        public static void DoWork(ref Location location)
        {
            location.Latitude += 0.1;
            location.Longitude += 0.2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(location);
            Console.ResetColor();
        }
    }


    // Struktura - zbiór pól (typ wartościowy)
    struct Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public override string ToString()
        {
            return $"lat: {Latitude} lng: {Longitude}";
        }
    }

    // Klasa - typ referencyjny
    class Person
    {
        public string FirstName { get; set; }

        public override string ToString()
        {
            return FirstName;
        }
    }

    class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string CustomerName { get; set; }


        public Order()
        {

        }

        public Order(int id, DateTime orderDate, decimal totalAmount, string customerName)
        {
            Id = id;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            CustomerName = customerName;
        }

        public override string ToString()
        {
            return $"{Id} {OrderDate} {CustomerName} {TotalAmount}";
        }
    }
}
