using System;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Debuger

            // F9 - wstawienie pułapki (punkt przerwania) - breakpoint
 
            // Edit-and-Continue Edycja w trakcie wykonywania programu

            Console.WriteLine("Hello World!");

            byte level = 4;

            bool isHigh = level > 7; // 11...
            bool isHigh2 = level >= 10; // 10...
            
            Console.WriteLine(isHigh);

            bool isLow = level < 5; // ..4
            bool isLow2 = level <= 4; //

            Console.WriteLine(isLow);

            bool isMyLevel = level == 7; // porównanie (equal)

            bool outMyLevel = level != 7;  // <> różne (not equal)


        }
    }
}
