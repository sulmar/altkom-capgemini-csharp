using System;
using ExtensionMethods;

namespace Printers
{
    class Printer
    {
        public void Print(string content)
        {
            Console.WriteLine(content.FirstLetterToUpper());
        }
    }
}
