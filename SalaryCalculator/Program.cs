using System;

namespace SalaryCalculator
{
    class Program
    {

        // Funkcja / Metoda
        static decimal CalculateSalary(decimal baseSalary, byte overTime)
        {
            const decimal overTimeRate = 50;

            decimal salary = baseSalary + overTime * overTimeRate;

            return salary;
        }

        static decimal GetBaseSalary()
        {
            Console.WriteLine("Podaj kwotę bazową: ");
            decimal baseSalary = decimal.Parse(Console.ReadLine());

            return baseSalary;
        }

        static byte GetOverTime()
        {
            Console.WriteLine("Podaj ilość pełnych przepracowanych nadgodzin: ");
            byte overtime = byte.Parse(Console.ReadLine());

            return overtime;
        }

        static void Display(decimal salary)
        {
            Console.WriteLine($"Twoje wynagrodzenie wynosi: {salary}");
        }

        static bool isKeepRunning()
        {
            Console.WriteLine("Czy kontynuować? [T/N]");

            string answer = Console.ReadLine();

            return answer == "T";


        }
       
        static void Main(string[] args)
        {
            do
            {
                decimal baseSalary = GetBaseSalary();
                byte overtime = GetOverTime();
                decimal salary = CalculateSalary(baseSalary, overtime);

                Display(salary);

            } while (isKeepRunning());


            // Z zabezpieczeniem

            bool keepRunning = false;

            do
            {
                Console.WriteLine("Podaj kwotę bazową: ");

                if (decimal.TryParse(Console.ReadLine(), out decimal baseSalary))
                {
                    Console.WriteLine("Podaj ilość pełnych przepracowanych nadgodzin: ");

                    if (byte.TryParse(Console.ReadLine(), out byte overtime))
                    {
                        // decimal salary = baseSalary + overtime * overTimeRate;
                        // ..
                        // ..
                        // ..
                        // ..
                        // ..
                        // ..
                        // ..
                        // ..


                        decimal salary = CalculateSalary(baseSalary, overtime);

                        Console.WriteLine($"Twoje wynagrodzenie wynosi: {salary}");
                    }
                    else
                    {
                        Console.WriteLine("Wprowadzono błędną wartość nadgodzin.");
                    }

                }
                else
                {
                    Console.WriteLine("Wprowadzono błędną wartość.");
                }

                Console.WriteLine("Czy kontynuować? [T/N]");

                string answer = Console.ReadLine();

                keepRunning = answer == "T";

            } while (keepRunning);

        }
    }
}
