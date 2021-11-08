using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            OrderState orderState = OrderState.Ordered;

            if (orderState == OrderState.Delivered)
            {
                Console.WriteLine("Dostarczono.");
            }

            DaysOfWeek dayOfWeek = DaysOfWeek.Thuesday;

            Gender gender = Gender.Female;

            Console.WriteLine($"Płeć {gender}. Dzień tygodnia: {dayOfWeek}");

            if (gender == Gender.Female)
            {
                Console.WriteLine("Pani");
            }
            else
            {
                Console.WriteLine("Pan");
            }
         
        }
    }

    // Typ wyliczeniowy - zbiór dopuszczalnych wartości
    enum Gender
    {
        Male = 3,
        Female = 5
    }

    enum DaysOfWeek
    {
        Monday,
        Thuesday,
        Whensday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum OrderState
    {
        Ordered = 0,
        Completion = 1,
        Sent = 2,
        Delivered = 3,
        Returned = 4,
        Cancelled = 5
    }


    // Zła praktyka
    //enum Cities
    //{
    //    Warszawa,
    //    Poznan,
    //    Bydgoszcz,
    //    Krakow,
    //    Wroclaw
    //}
}
