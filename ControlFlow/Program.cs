using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // jeśli klient ma powyżej 100 -> gold
            // w przeciwnym razie          -> silver

            int points = 101;

            // if - jeżeli 

            string customerType;

            if (points > 100)
            {
                customerType = "Gold";
            }
            else
            {
                customerType = "Silver";               
            }

           // Skrócona forma zapisu if-else: warunek-logiczny ? true : false
            customerType = points > 100 ? "Gold" : "Silver";

            Console.WriteLine(customerType);

            Console.Write("Podaj piętro: ");
            
            byte myFloor = byte.Parse(Console.ReadLine());

            byte currentFloor = 3;

            if (currentFloor > myFloor)
            {
                Console.WriteLine("v");
            }
            else if (currentFloor < myFloor)
            {
                Console.WriteLine("^");
            }
            else
            {
                Console.WriteLine("-");
            }


            byte numberOfMonth = 3;

            string monthName;

            //if (numberOfMonth==1)
            //{
            //    monthName = "Styczeń";
            //}
            //else if (numberOfMonth == 2)
            //{
            //    monthName = "Luty";
            //}
            //else if (numberOfMonth == 3)
            //{
            //    monthName = "Marzec";
            //}
            // else
            //{
            //    monthName = "Nieznany";
            //}

            switch(numberOfMonth)
            {
                case 1: monthName = "Styczeń"; break;
                case 2: monthName = "Luty"; break;
                case 3: monthName = "Marzec"; break;

                default: monthName = "Nieznany"; break;
            }


            bool highIncome = false;
            bool goodCreditScore = true;

            bool isApprovedLoan = highIncome && goodCreditScore; // Operator Logiczny AND (iloczyn logiczny)
            Console.WriteLine(isApprovedLoan);

            if (highIncome && goodCreditScore)
            {
                Console.WriteLine("Przydzielono");
            }
            else
            {
                Console.WriteLine("Odmowa");
            }


            bool canSendOffer = highIncome || goodCreditScore;  // Operator Logiczny OR (suma logiczna)
            Console.WriteLine(canSendOffer);



        }
    }
}
