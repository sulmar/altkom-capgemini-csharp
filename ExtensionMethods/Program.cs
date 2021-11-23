using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "JOhn";
            string lastName = "smiTH";

            firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1, firstName.Length - 1).ToLower();
            lastName = lastName.Substring(0, 1).ToUpper() + lastName.Substring(1, lastName.Length - 1).ToLower();


            Console.WriteLine($"{firstName} {lastName}");


        }
    }
}
