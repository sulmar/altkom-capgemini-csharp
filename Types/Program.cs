using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // # Typ logiczny (1-bitowy)
            bool isSent = true;
            Console.WriteLine($"bool: {bool.FalseString}...{bool.TrueString}");


            // # Typy liczbowe

            // ## Liczby Całkowite
          
           //  ushort -> System.UInt16

            // 8-bitowa liczba całkowita bez znaku
            byte age = 18; // 0..255
            Console.WriteLine($"byte: {byte.MinValue}...{byte.MaxValue}");
            // byte -> System.Byte 

            // 8-bitowa liczba całkowita ze znakiem (signed)
            sbyte roomTemperature = -127;
            Console.WriteLine($"sbyte: {sbyte.MinValue}...{sbyte.MaxValue}");

            // 16-bitowa liczba całkowita ze znakiem
            short altitude = -9000;
            Console.WriteLine($"short: {short.MinValue}...{short.MaxValue}");
            // short -> System.Int16

            Int16 alt = altitude;


            // 16-bitowa liczba całkowita bez znaku (unsigned)
            ushort numberOfVisits = 10000;
            Console.WriteLine($"ushort: {ushort.MinValue}...{ushort.MaxValue}");

            // 32-bitowa liczba całkowita ze znakiem
            int score = -481456;
            Console.WriteLine($"int: {int.MinValue}...{int.MaxValue}");
            // int -> Int32

            // 32-bitowa liczba całkowita bez znaku
            uint orderId = 481456;
            Console.WriteLine($"uint: {uint.MinValue}...{uint.MaxValue}");

            // 64-bitowa liczba całkowita ze znakiem
            long measureId = 10000000;
            Console.WriteLine($"long: {long.MinValue}...{long.MaxValue}");

            // 64-bitowa liczba całkowita bez znaku
            ulong capacity = 1;
            Console.WriteLine($"ulong: {ulong.MinValue}...{ulong.MaxValue}");


            // Liczby rzeczywiste

            // 16-bitowa liczba zmiennoprzecinkowa
            float temperature = 21.04f;
            Console.WriteLine($"float: {float.MinValue}...{float.MaxValue}");

            // 32-bitowa liczba zmiennoprzecinkowa
            double latitude = 10.00001;
            Console.WriteLine($"double: {double.MinValue}...{double.MaxValue}");

            // 64-bitowa liczba zmiennoprzecinkowa
            decimal unitPrice = 4.99m;
            Console.WriteLine($"decimal: {decimal.MinValue}...{decimal.MaxValue}");


            // 16-bitowy znak z tablicy Unicode
            char sign = 'A';
            Console.WriteLine($"char: {char.MinValue}...{char.MaxValue}");
            
            // Tekst 
            string name = "John";

            // Data
            DateTime loginDate = DateTime.Now;

            // Czas
            TimeSpan beginHour = TimeSpan.Parse("09:00");
            Console.WriteLine($"TimeSpan: {TimeSpan.MinValue}...{TimeSpan.MaxValue}");

            // C# 10
            // DateOnly
            // TimeOnly

        }
    }
}
