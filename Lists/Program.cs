using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> persons = new List<string>();

            persons.Add("Marek");
            persons.Add("Inessa");
            persons.Add("Serhii");
            persons.Add("Piotr");
            persons.Add("Szymon");
            persons.Add("Marek");

            string selectedPerson = persons[2];

            Console.WriteLine(selectedPerson);

            persons[1] = "Łukasz";

            for (int index = 0; index < persons.Count; index++)
            {
                string currentPerson = persons[index];
                Console.WriteLine($"{index} {currentPerson}");
            }

            // persons.Remove("Marek");
            persons.RemoveAt(5);

            persons.RemoveAll(MyFilter);
            persons.RemoveAll(p => p.Contains("Marek"));

          

            persons.Clear();

            foreach (string currentPerson in persons)
            {
                Console.WriteLine(currentPerson);
            }            

        }

        private static bool MyFilter(string p)
        {
            return p.Contains("Marek");
        }
    }
}
