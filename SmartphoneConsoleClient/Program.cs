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

            Batery batery = new Batery();

            Band band = new Band();
            band.ReplaceBatery(batery);

            band.Charge();


            Device device = CreateDevice();

            //            device.batery.bateryLevel = 110;

            //device.batery.SetBateryLevel(110);

            //byte level = device.batery.GetBateryLevel();

            // device.batery.BateryLevel = 110;

            byte level = device.BateryLevel;

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
            Device device = new Smartphone();

            GetManufacture(device);
            GetModel(device);
            GetEstimatedValue(device);
            GetBatery(device);
            GetCustomer(device);

            return device;
        }

        private static void GetBatery(Device device)
        {
            Console.Write("Czy jest bateria? Y/N ");

            switch (Console.ReadLine())
            {
                case "Y": device.ReplaceBatery(CreateBatery()); break;
                case "N": break;

                default: Console.WriteLine("Błędna wartość"); break;
            }
        }

        private static void GetCustomer(Device device)
        {
            Console.WriteLine("---- customer info ----");
            device.Owner = CreateCustomer();
        }

        private static Batery CreateBatery()
        {
            Console.Write("Podaj poziom naładowania baterii: ");

            if (byte.TryParse(Console.ReadLine(), out byte level))
            {
                return new Batery(level);
            }
            else
            {
                return new Batery();
            }

            // return new Batery { bateryLevel = level };

        }

        private static Customer CreateCustomer()
        {
            Console.Write("Podaj imię: ");
            string firstName = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("Podaj telefon kontaktowy: ");
            string phoneNumber = Console.ReadLine();

            Customer customer = new Customer(lastName, phoneNumber);
            customer.FirstName = firstName;

            return customer;
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
            device.Manufacture = Console.ReadLine();
        }

        static void GetModel(Device device)
        {
            Console.Write("Podaj model: ");
            device.Model = Console.ReadLine();
        }
    }


    public class Smartphone : Device    // dziedziczenie 
    {
        public byte SignalLevel // smartphone    .... band (opaska)
        {
            get
            {
                return 10;
            }
        }

        public byte Volume
        {
            get
            {
                return 100;
            }
        }
    }

    public class Band : Device
    {
        public byte Pulse
        {
            get
            {
                return 120;
            }
        }
    }

    public class Smartwatch : Device
    {
        
    }


    abstract public class Device
    {
        // Właściwości
        public string Manufacture { get; set; }
        public string Model { get; set; }


        public Customer Owner { get; set; }
        
        private Batery batery; // null, posiada obiekt typu Batery

      

        // Hermetyzacja - ukrywanie szczegółów budowy/implementacji
        public byte BateryLevel
        {
            get
            {
                return batery.BateryLevel;
            }
        }

        public void ReplaceBatery(Batery batery)
        {
            this.batery = batery;
        }

        public void RemoveBatery()
        {
            this.batery = null;
        }


        public bool HasBatery()
        {
            return batery != null;
        }
        
        public decimal estimatedValue;

        public bool IsCharged()
        {
            if (HasBatery())
            {
                return batery.IsCharged();
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
        private const byte chargedLimit = 70;
        private const byte maxBateryLevel = 100;

        // Pole (field)
        private byte bateryLevel;


        // Właściwość (property)
        /*
        public byte BateryLevel
        {
            // Getter
            get
            {
                return this.bateryLevel;
            }

            // Setter
            set
            {
                if (value <= maxBateryLevel)
                {
                    this.bateryLevel = value;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }

        */

        public byte BateryLevel
        {
            get
            {
                return this.bateryLevel;
            }

            private set
            {
                if (value <= maxBateryLevel)
                {
                    this.bateryLevel = value;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }

        }

        /*
         
        // Getter
        public byte GetBateryLevel()
        {
            return this.bateryLevel;
        }

        // Setter
        public void SetBateryLevel(byte value)
        {
            if (value<=100)
            {
                this.bateryLevel = value;
            }
            else
            {
                throw new InvalidOperationException();
            }
            
        }


        */



        // constructor - specjalna metoda uruchamiania przy tworzeniu obiektu za pomocą operatora new()
        // konstruktor - metoda ma taką samą nazwę jak klasa i nic nie zwraca
        public Batery(byte level = 100)   // przeciążanie konstruktorów
        {
            this.BateryLevel = level;
        }

        // Konstruktor domyślny 
        //public Batery()
        //{
        //    this.bateryLevel = 100;
        //}


        public bool IsCharged()
        {
            return bateryLevel > chargedLimit;
        }

        public void Charge()
        {
            for (int i = BateryLevel; i <= maxBateryLevel; i++)
            {
                Console.WriteLine($"Charging... {BateryLevel++}");

                Thread.Sleep(1000);
            }
        }

       
    }

    public class Customer
    {
        private string pesel;

        private string _firstName;
        
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }


        public string LastName { get; set; }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get => _phoneNumber;

            set
            {
                if (value.Length == 6)
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }

        public Customer(string lastName, string phoneNumber)
        {
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
        }

        // zła praktyka
        //public Customer(string firstName, string lastName, string phoneNumber)
        //{
        //    this.firstName = firstName;

        //    this.lastName = lastName;
        //    this.phoneNumber = phoneNumber;
        //}

        // dobra praktyka
        public Customer(string firstName, string lastName, string phoneNumber)
            : this(lastName, phoneNumber)
        {
            this.FirstName = firstName;
        }

    }
}
