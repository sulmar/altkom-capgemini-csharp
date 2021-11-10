using System;
using System.Collections.Generic;
using System.Threading;

namespace SmartphoneConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Device device = CreateDevice();
            
            if (!device.IsCharged())
            {
                device.Charge();
            }



           // GetDevices();

        }

        private static void GetDevices()
        {
            List<Device> devices = new List<Device>();

            while (true)
            {
                Device device = CreateDevice();

                devices.Add(device);
            }
        }

        static Device CreateDevice()
        {
            Device device = new Device();
            
            GetManufacture(device);
            GetModel(device);
            GetEstimatedValue(device);
            GetBatery(device);

            return device;
        }

        private static void GetBatery(Device device)
        {
            Console.Write("Czy jest bateria? Y/N ");

            switch(Console.ReadLine())
            {
                case "Y": device.batery = CreateBatery() ; break;
                case "N": break;

                default: Console.WriteLine("Błędna wartość"); break;
            }
        }

        private static Batery CreateBatery()
        {
            Console.Write("Podaj poziom naładowania baterii");

            byte level = byte.Parse(Console.ReadLine());

            return new Batery { bateryLevel = level };
        }

        private static void GetEstimatedValue(Device device)
        {
            Console.Write("Podaj szacowaną wartość: ");

            if (decimal.TryParse(Console.ReadLine(), out device.estimatedValue))
            {

            }
            else
            {
                Console.WriteLine("Błędną wartość!");
            }
        }

        static void GetManufacture(Device device)
        {
            Console.Write("Podaj producenta: ");
            device.manufacture = Console.ReadLine();
        }

        static void GetModel(Device device)
        {
            Console.Write("Podaj model: ");
            device.model = Console.ReadLine();
        }


    }

    public class Device
    {
        public string manufacture;
        public string model;

        public Customer owner;
        public Batery batery; // null, posiada obiekt typu Batery

        private const byte ChargedLimit = 70;

        public bool HasBatery()
        {
            return batery != null;
        }
        
        public decimal estimatedValue;

        public bool IsCharged()
        {
            if (HasBatery())
            {
                return batery.bateryLevel > ChargedLimit;
            }
            else
            {
                return false;
            }            
        }

        public void Charge()
        {
            batery.Charge();
        }


    }

    public class Batery
    {
        public byte bateryLevel;

        private const byte maxBateryLevel = 100;

        public void Charge()
        {
            for (int i = bateryLevel; i <= maxBateryLevel; i++)
            {
                Console.WriteLine($"Charging... {i}");

                Thread.Sleep(1000);
            }
        }
    }

    public class Customer
    {
        public string firstName;
        public string lastName;
        public string phoneNumber;
    }
}
