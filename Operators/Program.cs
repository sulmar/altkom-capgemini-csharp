using System;

namespace Operators
{
    class Program
    {

        // ctrl K+D - sformatowanie kodu

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int points = 0;

            points = points + 1;  // = - przypisanie 

            Console.WriteLine(points++); // post inkrementacja +1
            Console.WriteLine(++points); // pre inkrementacja +1
            Console.WriteLine(points);

            points = points - 1;
            Console.WriteLine(points--); // post dekrementacja -1
            Console.WriteLine(--points); // pre dekrementacja -1

            points = points + 10;
            points += 10;

            points = points - 10;
            points -= 10;

            points = points * 2;
            points *= 2;
        }
    }
}
