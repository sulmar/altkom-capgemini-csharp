using System;

namespace Methods
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Podaj symbol: ");
            string input = Console.ReadLine();

            char symbol = char.Parse(input);

            // Spaghetti code

            decimal baseSalary1 = 5000;
            int overtime1 = 10;
            decimal rate = 100;

            decimal baseSalary2 = 4000;
            int overtime2 = 5;


            decimal baseSalary3 = 4000;
            int overtime3 = 5;

            // Don't repeat yourself! DRY 
            decimal salary1 = baseSalary1 + overtime1 * rate + 100;
            decimal salary2 = baseSalary2 + overtime2 * rate + 100;
            decimal salary3 = baseSalary3 + overtime3 * rate + 100;

            Console.WriteLine("======");
            Console.WriteLine(salary1);
            Console.WriteLine("======");

            Console.WriteLine("======");
            Console.WriteLine(salary2);
            Console.WriteLine("======");

            Console.WriteLine("======");
            Console.WriteLine(salary3);
            Console.WriteLine("======");

            decimal _salary1 = CalculateSalary(5000, rate: 100, overtime: 110);
            decimal _salary2 = CalculateSalary(4000, overtime: 5, rate: rate);
            decimal _salary3 = CalculateSalary(4000, 20);

            DisplaySalary(symbol, _salary1);
            DisplaySalary(symbol, _salary2);
            DisplaySalary(symbol, _salary3);
        }

        // Metoda (funkcja) -> posiada parametry i zwraca wartość
        static decimal CalculateSalary(decimal baseSalary, int overtime, decimal rate = 100) // argumenty - są lokalne
        {
            // calculate
            decimal salary = baseSalary + overtime * rate + 1;  // salary - lokalna zmienna

            return salary;

           // return baseSalary + overtime * rate + 1;

        }

        // Metoda (funkcja) ->  posiada parametr ale nie zwraca wartości
        static void DisplaySalary(char sign, decimal salary)
        {
            DisplayLine(symbol: sign, length: 20);
            Console.WriteLine(salary);
            DisplayLine(5);
            DisplayLine((byte)5);
            DisplayLine();
        }

        // Metoda z parametrami opcjonalnymi
        static void DisplayLine(char symbol = '*', byte length = 10) // symbol - parametr opcjonalny
        {
            string line = new string(symbol, length);

            Console.WriteLine(line);
        }

        // Metoda (funkcja) -> nie posiada parametrów ani nie zwraca wartości
        //static void DisplayLine()           // przeciążanie metod (overloading)
        //{
        //    Console.WriteLine("************");
        //}

        //static void DisplayLine(byte length)
        //{
        //    string line = new string('*', length);

        //    Console.WriteLine(line);
        //}

        static void DisplayLine(int length)
        {
            string line = new string('*', length);

            Console.WriteLine(line);
        }


    }
}
