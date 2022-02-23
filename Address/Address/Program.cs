using System;

namespace Address
{
    class Addres
    {
        public string Country;
        public string City;
        public string Street;
        public int House;
        public int Flat;
        static int counterHouse;
        static int counterObject;

        public string country
        {
            get { return Country; }
            set
            {
                if (value == "") Country="Error.";
                else
                {
                    Country = value;
                }
            }
        }
        public string city
        {
            get { return City; }
            set
            {
                if (value == "") City = "Error.";
                else
                {
                    City = value;
                }
            }
        }
        public string street
        {
            get { return Street; }
            set
            {
                if (value == "") Street = "Error.";
                else
                {
                    Street = value;
                }
            }
        }
        public int house
        {
            get { return House; }
            set
            {
                if (value < 100 && value>0)
                {
                    House = value;
                }
                else
                {
                    House = 0;
                    Console.WriteLine("Значение дома превосходит допустимый предел \n");
                }
            }
        }
        public int flat
        {
            get { return Flat; }
            set
            {
                if (value < 100 && value > 0)
                {
                    Flat = value;
                }
                else
                {
                    Console.WriteLine("Значение квартиры превосходит допустимый предел \n");
                    Flat = 0;
                }
            }
        }
        public Addres()
        {
            country = "Неизвестно";
            city = "Неизвестно";
            street = "Неизвестно";
            house = 0;
            flat = 0;
            if (house % 2 == 0 && house != 0) counterHouse++;
            counterObject++;
        }
        public Addres(string _country, string _city, string _street)
        {
            country = _country;
            street = _street;
            city = _city;
            house = 0;
            flat = 0;
            if (house % 2 == 0 && house!=0) counterHouse++;
            counterObject++;
        }
        public Addres(int _house, int _flat)
        {
            country = "Неизвестно";
            city = "Неизвестно";
            street = "Неизвестно";
            house = _house;
            flat = _flat;
            if (_house % 2 == 0 && house != 0) counterHouse++;
            counterObject++;
        }
        public Addres(string _country, string _city, string _street, int _house, int _flat)
        {
            country = _country;
            street = _street;
            city = _city;
            house = _house;
            flat = _flat;
            if (_house % 2 == 0 && house != 0) counterHouse++;
            counterObject++;
        }
        public void GetAddress()
        {
            Console.WriteLine($"Страна проживания:{country} \nГород проживания:{city} \nУлица проживания:{street} \nДом:{house} \nКвартира:{flat}");
        }
        public void GetHouses()
        {
            Console.WriteLine($"Четных домов:{counterHouse}");
        }
        public void GetObjects()
        {
            Console.WriteLine($"Объектов:{counterObject}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
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
                if (i < 4)
                {
                    switch (r)
                    {
                        case "1":
                            Addres patient = new Addres();
                            patient.GetAddress();
                            Console.WriteLine("Хотите узнать количество четных домов?Yes/No");
                            string questen = Console.ReadLine();
                            if (questen == "Yes") patient.GetHouses();
                            Console.WriteLine("Хотите узнать количество объектов?Yes/No");
                            string questen5 = Console.ReadLine();
                            if (questen5 == "Yes") patient.GetObjects();
                            break;
                        case "2":
                            Addres patient2 = new Addres(country, city, street);
                            patient2.GetAddress();
                            Console.WriteLine("Хотите узнать количество четных домов?Yes/No");
                            string questen1 = Console.ReadLine();
                            if (questen1 == "Yes") patient2.GetHouses();
                            Console.WriteLine("Хотите узнать количество объектов?Yes/No");
                            string questen6 = Console.ReadLine();
                            if (questen6 == "Yes") patient2.GetObjects();
                            break;
                        case "3":
                            Addres patient3 = new Addres(K, M);
                            patient3.GetAddress();
                            Console.WriteLine("Хотите узнать количество четных домов?Yes/No");
                            string questen2 = Console.ReadLine();
                            if (questen2 == "Yes") patient3.GetHouses();
                            Console.WriteLine("Хотите узнать количество объектов?Yes/No");
                            string questen7 = Console.ReadLine();
                            if (questen7 == "Yes") patient3.GetObjects();
                            break;
                        case "4":
                            Addres patient4 = new Addres(country, city, street, K, M);
                            patient4.GetAddress();
                            Console.WriteLine("Хотите узнать количество четных домов?Yes/No");
                            string questen3 = Console.ReadLine();
                            if (questen3 == "Yes") patient4.GetHouses();
                            Console.WriteLine("Хотите узнать количество объектов?Yes/No");
                            string questen8 = Console.ReadLine();
                            if (questen8 == "Yes") patient4.GetObjects();
                            break;
                    }
                }
                else
                {
                    switch (r)
                    {
                        case "1":
                            Console.WriteLine("Введите причину удаления адреса: ");
                            string reason = Console.ReadLine();
                            RemoteAddress patient = new RemoteAddress(reason);
                            patient.GetAddress();
                            Console.WriteLine("Хотите узнать количество четных домов?Yes/No");
                            string questen = Console.ReadLine();
                            if (questen == "Yes") patient.GetHouses();
                            Console.WriteLine("Хотите узнать количество объектов?Yes/No");
                            string questen5 = Console.ReadLine();
                            if (questen5 == "Yes") patient.GetObjects();
                            break;
                        case "2":
                            Console.WriteLine("Введите причину удаления адреса: ");
                            string reason1 = Console.ReadLine();
                            RemoteAddress patient2 = new RemoteAddress(country, city, street,reason1);
                            patient2.GetAddress();
                            Console.WriteLine("Хотите узнать количество четных домов?Yes/No");
                            string questen1 = Console.ReadLine();
                            if (questen1 == "Yes") patient2.GetHouses();
                            Console.WriteLine("Хотите узнать количество объектов?Yes/No");
                            string questen6 = Console.ReadLine();
                            if (questen6 == "Yes") patient2.GetObjects();
                            break;
                        case "3":
                            Console.WriteLine("Введите причину удаления адреса: ");
                            string reason2 = Console.ReadLine();
                            RemoteAddress patient3 = new RemoteAddress(K, M,reason2);
                            patient3.GetAddress();
                            Console.WriteLine("Хотите узнать количество четных домов?Yes/No");
                            string questen2 = Console.ReadLine();
                            if (questen2 == "Yes") patient3.GetHouses();
                            Console.WriteLine("Хотите узнать количество объектов?Yes/No");
                            string questen7 = Console.ReadLine();
                            if (questen7 == "Yes") patient3.GetObjects();
                            break;
                        case "4":
                            Console.WriteLine("Введите причину удаления адреса: ");
                            string reason3 = Console.ReadLine();
                            RemoteAddress patient4 = new RemoteAddress(country, city, street, K, M,reason3);
                            patient4.GetAddress();
                            Console.WriteLine("Хотите узнать количество четных домов?Yes/No");
                            string questen3 = Console.ReadLine();
                            if (questen3 == "Yes") patient4.GetHouses();
                            Console.WriteLine("Хотите узнать количество объектов?Yes/No");
                            string questen8 = Console.ReadLine();
                            if (questen8 == "Yes") patient4.GetObjects();
                            break;
                    }
                }
            }
        }
    }
}
