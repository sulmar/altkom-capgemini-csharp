using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PrintedEventArgs : EventArgs
    {
        public int Copies { get; }
        public decimal? Cost { get;  }

        public PrintedEventArgs(int copies, decimal? cost)
        {
            Copies = copies;
            Cost = cost;
        }
    }

    public class Printer
    {
        //public delegate void LogDelegate(string message);   // Sygnatura
        //public LogDelegate Log;                             // Utworzenie zmiennej typu LogDelegate
        public Action<string> Log;

        //public delegate decimal CostDelegate(int length);
        //public CostDelegate Cost;
        public Func<int, decimal> Cost;

        public delegate void CompletedDelegate();
        public event CompletedDelegate Completed;       // Zdarzenie - delegat, który może być wywołane przed właściciela

        //public delegate void PrintedDelegate(object sender, PrintedEventArgs args);
        //public event PrintedDelegate Printed;
        public EventHandler<PrintedEventArgs> Printed;

        public void Print(string content, byte copies = 1)
        {
            for (int copy = 0; copy < copies; copy++)
            {
                Log?.Invoke($"{DateTime.Now} Printing {content} Copy #{copy}");                
            }

            // Uwaga na NullReferenceExcepction
            //if (Cost!=null)
            //{
            //    cost = Cost.Invoke(content.Length * copies);
            //}

            decimal? cost = Cost?.Invoke(content.Length * copies);

            if (cost.HasValue)
            {
                DisplayLCD(cost.Value);
            }

            Completed?.Invoke();

            Printed?.Invoke(this, new PrintedEventArgs(copies, cost));
        }

        //private void DisplayLCD(decimal cost)
        //{
        //    Console.WriteLine($"LCD {cost}");
        //}

        private void DisplayLCD(decimal cost) => Console.WriteLine($"LCD {cost}");
    }
}
