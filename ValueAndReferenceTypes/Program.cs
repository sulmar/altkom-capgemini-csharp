using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Typy wartościowe (proste)");
            // int, byte, float, DateTime, bool, struct

            int x = 10;
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
    }

    class Person
    {
        public string FirstName { get; set; }
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
