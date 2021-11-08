using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 0..255
            byte age;

            // -2^31..2^31
            int myAge = 157;    // Konwersja niejawna (implicit)

            checked
            {
                age = (byte) myAge; // Konwersja jawna (explicit)
            }

            Console.WriteLine(age); // <--- ???     exception / 0 / overflow        

            float latitude = 24.01f;
            double lat = latitude; // Konwersja niejawna (implicit)

            double longitude = 53.01d;
            float lng = (float) longitude; // Konwersja jawna (explicit)

            string number = "100";
            byte happyNumber = byte.Parse(number);

            // byte happyNumber2 = Convert.ToByte(number);

            string input = "2021-11-08 16:00";
            DateTime orderDate = DateTime.Parse(input);
            Console.WriteLine(orderDate);

            string hourInput = "08:30";
            TimeSpan beginHour = TimeSpan.Parse(hourInput);
            Console.WriteLine(beginHour);

            string inputIsRemoved = "true";
            bool isRemoved = bool.Parse(inputIsRemoved);
            Console.WriteLine(isRemoved);
        }
    }
}
