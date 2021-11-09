using System;

namespace HelloWorld
{
    class Program
    {
        readonly static DateTime loginDate = DateTime.Now;  // Zmienna tylko do odczytu

        static void Main(string[] args)
        {
            int experience = 0;

            const int limitExperience = 3;           // Stała

            Console.Write("Podaj imię: ");
            string firstName = Console.ReadLine(); // Odczytuje tekst wprowadzony z lini poleceń

            Console.Write("Podaj nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("Ile masz lat doświadczenia w C#?: ");
            string input = Console.ReadLine();
            
            experience = int.Parse(input); // konwersja + zgłaszanie błędów
                                           // experience = Convert.ToInt32(input); // konwersja + zgłaszanie błędów

            /* Różnica pomiędzy Parse a Convert
             
            string input = null;
	
	        int number = Convert.ToInt32(input);  // returns 0
	
        	int number = int.Parse(input); //  throws ArgumentNullException

            */

            // Console.WriteLine("Witaj " + firstName + " " + lastName + "!"); // Konkatenacja
            //  Console.WriteLine("Miło, że masz " + experience + " lat doświadczenia.");

            // string message = "Witaj " + firstName + " " + lastName + "!";
            // string message = string.Format("Witaj {0} {2}!", firstName, lastName);
            string message = $"Witaj {firstName} {lastName.ToUpper()}!"; // Interpolacja

            // string experienceMessage = string.Format("Miło że masz {0} lat doświadczenia!", experience);
            string experienceMessage = $"Miło że masz {experience} lat doświadczenia. Data zalogowania: {loginDate}";

            decimal unitPrice = 1.997m;
            
            string adsMessage1 = $"Cena produktu {unitPrice:c2}"; // 1,99 zł

            Console.WriteLine(adsMessage1);

            string adsMessage2 = $"Cena produktu {unitPrice:n2} PLN"; // 1,99 PLN
            Console.WriteLine(adsMessage2);

            Console.WriteLine(message);
            Console.WriteLine(experienceMessage);
        }
    }
}
