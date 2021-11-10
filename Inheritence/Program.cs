using System;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee employee = new Intern();
            employee.FirstName = "John";
            employee.LastName = "Smith";
            employee.DoWork();

        }
    }

    abstract class Employee // abstract nie można utworzyć instancji tej klasy 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // Metoda z domyślnym działaniem
        public virtual void DoWork()            // polimorfizm (wielopostaciowość)
        {
            Console.WriteLine("Working...");
        }
    }

    class Intern : Employee
    {
      
    }

    class Junior : Employee // dziedziczenie
    {
        public decimal Salary { get; set; }

        public override void DoWork()
        {
            Console.WriteLine($"Working for salary {Salary}");
        }

    }

    class Senior : Junior   // dziedziczenie
    {
        public decimal Bonus { get; set; }

        public override void DoWork()   
        {
            base.DoWork();
            Console.WriteLine($"and for bonus {Bonus}");
        }
    }
}
