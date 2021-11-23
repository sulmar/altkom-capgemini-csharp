using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;

namespace Exceptions
{
    class Person
    {
        public decimal SalaryBase { get; set; }
    }

    class SalaryCalculator
    {
        public decimal Calculate(Person person, decimal bonus, byte age)
        {
            // Walidacja

            if (person == null)
            {
                throw new ArgumentNullException("person");
            }

            if (bonus <= 0)
            {
                throw new ArgumentOutOfRangeException("salary");
            }

            if (age < 18 &&  age > 100)
            {
                throw new ArgumentOutOfRangeException("age");
            }

            return person.SalaryBase + bonus * age;  // algorytm (logika biznesowa)
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                SalaryCalculator salaryCalculator = new SalaryCalculator();
                var salary = salaryCalculator.Calculate(null, 100, 1);

                Console.WriteLine(salary);

            }
            catch
            {

            }

            int x = 10;
            int y = 0;

            DbConnection connection = new SqlConnection();

            try
            {

                // Connect
                connection.Open();

                // SQL: update ....
                throw new Exception();

                // Disconnect
            }
            catch(Exception)
            {
                Console.WriteLine($"Błąd podczas komunikacji z bazą danych.");
            }
            finally
            {
                connection.Close();
            }


            try
            {
                string content = File.ReadAllText("plik.txt");
            }
            catch(FileNotFoundException e)
            {                
                Console.WriteLine($"Plik {e.FileName} nie istnieje");
            }


            if (File.Exists("plik.txt"))
            {
                string content = File.ReadAllText("plik.txt");
            }
            else
            {
                Console.WriteLine($"Plik nie istnieje");
            }

            try
            {
                int result = x / y;

                Console.WriteLine(result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Nie wolno dzielić przez 0");
            }

            //if (y != 0)
            //{
            //    int result = x / y;

            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Nie wolno dzielić przez 0");
            //}
        }
    }
}
