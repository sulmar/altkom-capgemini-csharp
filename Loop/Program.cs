using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 5;

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i} Hello .NET!");
            }

            for (int i = count; i > 0; i--)
            {
                Console.WriteLine($"{i} Hello .NET!");
            }

            byte currentTemperature = 101;

            // 0..n
            while(currentTemperature < 100)
            {
                Console.WriteLine($"Podgrzewanie... {currentTemperature}");

                currentTemperature++;
            }

            Console.WriteLine("Gwizdek!");

            int speed; 
            do   // 1..n
            {
                Console.WriteLine("Podaj prędkość: ");
                speed = int.Parse(Console.ReadLine());


            } while (speed < 140);


        }
    }
}
