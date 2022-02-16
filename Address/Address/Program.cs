using System;

namespace Address
{
    class Address
    {
        public string _country;
        public string _city;
        public string _street;
        public int _house;
        public int _flat;

        public Address()
        {
            _country = "Неизвестно";
            _city = "Неизвестно";
            _street = "Неизвестно";
            _house = 0;
            _flat = 0;
        }
        public Address(string country, string city, string street)
        {
            _country = country;
            _street = street;
            _city = city;
            _house = 0;
            _flat = 0;
        }
        public Address(int house, int flat)
        {
            _country = "Неизвестно";
            _city = "Неизвестно";
            _street = "Неизвестно";
            _house = house;
            _flat = flat;
        }
        public Address(string country, string city, string street, int house, int flat)
        {
            _country = country;
            _street = street;
            _city = city;
            _house = house;
            _flat = flat;
        }
        public void GetAddress()
        {
            Console.WriteLine($"Страна проживания:{_country} \nГород проживания:{_city} \nУлица проживания:{_street} \nДом:{_house} \nКвартира:{_flat}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Страна");
                string country = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Город");
                string city = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Улица");
                string street = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Дом");
                string k = Console.ReadLine();
                int K;
                if (k == "")
                {
                    K = 0;
                }
                else
                {
                    K = Convert.ToInt32(k);
                }
                Console.WriteLine("");

                Console.WriteLine("Квартира");
                string m = Console.ReadLine();
                int M;
                if (m == "")
                {
                    M = 0;
                }
                else
                {
                    M = Convert.ToInt32(m);
                }
                Console.WriteLine("");
                Console.WriteLine("Введите номер конструктора");
                string r = Console.ReadLine();
                switch (r)
                {
                    case "1":
                        Address patient = new Address();
                        patient.GetAddress();
                        break;
                    case "2":
                        Address patient2 = new Address(country, city, street);
                        patient2.GetAddress();
                        break;
                    case "3":
                        Address patient3 = new Address(K, M);
                        patient3.GetAddress();
                        break;
                    case "4":
                        Address patient4 = new Address(country, city, street, K, M);
                        patient4.GetAddress();
                        break;
                }
            }
        }
    }
}
