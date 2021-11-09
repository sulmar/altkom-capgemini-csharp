using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // dyskretne
            int x = 10;
            int y = 20;

            decimal unitPrice = 10.99m;

            string person1 = "Marek";
            string person2 = "Inessa";
            string person3 = "Serhii";
            string person4 = "Piotr";
            string person5 = "Szymon";

            // Tablica - ma określoną liczbę elementów

            string line = new string('*', 10); // new() - wywołanie konstuktora

            string[] persons = new string[13];
            persons[0] = "Marek";
            persons[1] = "Inessa";
            persons[2] = "Serhii";
            persons[3] = "Piotr";
            persons[4] = "Szymon";

            persons[6] = "";
            persons[7] = "Grzegorz";

            int count = persons.Length;

            string selectedPerson = persons[5];

            if (selectedPerson is null)
            {
                Console.WriteLine("Brak osoby");
            }
            else
            {
                Console.WriteLine(selectedPerson);
            }


            // iteracja z użyciem pętli for
            for (int index = 0; index < persons.Length; index++)
            {
                string currentPerson = persons[index];

                Console.WriteLine($"{index+1} - {currentPerson}");
            }

            // iteracja z użyciem foreach

            int _index = 1;

            foreach(string currentPerson in persons)
            {
                Console.WriteLine($"{_index++} - {currentPerson}");
            }

            // string[] active = new string[] { "Grzegorz", "Marek", "Tobiasz" };

            string[] active = new string[] { "Grzegorz", "Marek", "Tobiasz" };

            decimal[] salaries = { 100, 150, 120, 0 }; // { } - inicjalizator


            byte[] rgbColor = new byte[3] { 100, 200, 0 };
            byte[] cmykColor = new byte[4] { 100, 200, 0, 10 };

            byte[] peselWeight = new byte[11];



        }
    }
}
