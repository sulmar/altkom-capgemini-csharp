using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "JOhn";
            string lastName = "smiTH";

            //firstName = StringHelper.FirstLetterToUpper(firstName);
            //lastName = StringHelper.FirstLetterToUpper(lastName);

            string firstName2 = "gRzegorz";
            string lastName2 = "IKSIŃSKI";

            /// Console.WriteLine($"{StringHelper.FirstLetterToUpper(firstName2)} {StringHelper.FirstLetterToUpper(lastName2)}");
            /// 
            Console.WriteLine($"{firstName.FirstLetterToUpper()} {lastName.FirstLetterToUpper()}");

            Console.WriteLine($"{firstName} {lastName}".WaveString());

            Console.WriteLine("John Smith".WaveString());

            Console.WriteLine("John Smith".Mask("."));

        }
    }

    //public class StringHelper
    //{
    //    public static string FirstLetterToUpper(string value)
    //    {
    //        return value.Substring(0, 1).ToUpper() + value.Substring(1, value.Length - 1).ToLower();
    //    }
    //}

    public static class StringExtensions
    {
        // Metoda rozszerzająca (Extension Method)
        public static string FirstLetterToUpper(this string value)  // <- rozszerzamy typ string o metodę FirstLetterToUpper
        {
            return value.Substring(0, 1).ToUpper() + value.Substring(1, value.Length - 1).ToLower();
        }

        // JaCk SmItH
        public static string WaveString(this string value)
        {
            string result = string.Empty;

            for (int i = 0; i < value.Length; i++)
            {
                string sign = value.Substring(i, 1);

                if (string.IsNullOrWhiteSpace(sign))
                {
                    result += sign;
                }
                else
                if (i % 2 == 0)
                {
                    result += sign.ToUpper();
                }
                else
                {
                    result += sign.ToLower();
                }
            }

            return result;
        }

        // **** *****
        // Metoda rozszerzająca może posiadać wiele parametrów
        // UWAGA: może być tylko jeden parametr this i musi być na pierwszej pozycji
        public static string Mask(this string value, string mask = "*")
        {
            string result = string.Empty;

            for (int i = 0; i < value.Length; i++)
            {
                string sign = value.Substring(i, 1);

                if (string.IsNullOrWhiteSpace(sign))
                {
                    result += sign;
                }
                else                
                {
                    result += mask;
                }
            }

            return result;
        }

    }
}
