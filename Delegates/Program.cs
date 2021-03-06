using System;

namespace Delegates
{
    class Program
    {
        static decimal CalculateStandardCost(int length)
        {
            return length * 0.99m;
        }

        static decimal CalculateHappyHoursCost(int length)
        {
            if (DateTime.Now.TimeOfDay > TimeSpan.Parse("09:00")  &&  DateTime.Now.TimeOfDay < TimeSpan.Parse("16:00"))
            {
                return decimal.Zero;
            }
            else
            {
                return length * 0.99m;
            }
        }

        static void Main(string[] args)
        {
            DelegateTest();

            Printer printer = new Printer();
            printer.Log += SendColorConsole;
            printer.Log += SendFacebook;
            printer.Log += Console.WriteLine;

             printer.Cost += CalculateStandardCost;     // f(x) = x + 2  x nalezy do C

            // Metoda anonimowa
            //printer.Cost += delegate (int length)     
            //{
            //    return length * 0.99m;
            //};

            // Metoda anonimowa zapisana za pomocą wyrażenia lambda
            printer.Cost += p => p * 0.99m;   // length -> length + 0.99m  length nalezy do C

            // f(x) = 2         - ()  -> 2
            // f(x, y) = x + y  - x,y -> x + y


            /* 
                decimal CalculateStandardCost(int p)
                {
                    return p * 0.99m;
                }

                 bla => bla * 0.99m;
            */


            // printer.Cost += CalculateHappyHoursCost;

            // Metoda anonimowa
            //printer.Completed += delegate ()
            //{
            //    Console.WriteLine("Koniec wydruku");
            //};



            Delegate[] delegates = printer.Cost.GetInvocationList();


            // Metoda anonimowa zapisana za pomocą wyrażenia lambda
            printer.Completed += () => Console.WriteLine("Koniec wydruku");

            printer.Printed += Printer_Printed;
            
            printer.Print("Hello World!", 3);

            //SendConsole("Hello World!");
            //SendColorConsole("Hello World!");
            //SendSms("Hello World!");
            //SendFacebook("Hello World!");

            




        }

        private static void Printer_Printed(object sender, PrintedEventArgs args)
        {
            Console.WriteLine($"Wydrukowano {args.Copies} kopii. Koszt {args.Cost}");
        }

        private static void DelegateTest()
        {
            Send send = null;

            if (send != null)
                send.Invoke("Hello!");

            send?.Invoke("Hello!");

            send += SendConsole; // subskrypcja
            send += SendColorConsole;
            send += SendFacebook;
            send += SendFacebook;

            send -= SendFacebook;

            Delegate[] delegates = send.GetInvocationList();

            // Wywołanie
            send.Invoke("Hello World!");

            send -= SendColorConsole;
            send.Invoke("Hello C#");
        }

        // Deklaracja delegatu
        delegate void Send(string message);


        static void DoNothing(string message)
        {}

        static void SendConsole(string message)
        {
            Console.WriteLine($"Send {message}");
        }

        static void SendColorConsole(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Send {message}");
            Console.ResetColor();
        }

        static void SendColorConsole(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Send {message}");
            Console.ResetColor();
        }

        static void SendSms(string message)
        {
            Console.WriteLine($"Send {message} via sms gateway");
        }
        static void SendFacebook(string post)
        {
            Console.WriteLine($"Send {post} to facebook");
        }
    }

}
