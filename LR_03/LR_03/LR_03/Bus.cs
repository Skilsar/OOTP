using System;
using System.Collections.Generic;
using System.Text;

namespace LR_03
{
    partial class Bus
    {

        private string lastName; //Фамилия
        private string inizial;  //Инициалы водителя
        private int idBus;          //Номер автобуса  
        private int lineId;      //Номер маршрута 
        const string brand = "Mercedes Benz"; //Марка
        private int exp;         //Год начала эксплуатации
        private int mileage;     //Пробег
        private int age;         //Возрост автобуса
        private int id;          //Хеш-код

        //Создать массив объектов. Вывести:
        //a) список автобусов для заданного номера маршрута;
        //b) список автобусов, которые эксплуатируются больше заданного срока;


        public Bus() { }

        public Bus(string lastName, string inizial, int idBus, int lineId, int exp, int mileage, int age) //конструктор
        {

            this.lastName = lastName;
            this.inizial = inizial;
            this.idBus = idBus;
            this.lineId = lineId;
            this.exp = exp;
            this.mileage = mileage;
            this.id = this.GetHashCode();
            this.age = age;

            //проверка корректности года эксплуатации
            if (exp < 1900 || exp > 2021)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Warning! Для автобуса №{idBus} задан неверный год эксплуатации!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            //проверка корректности Фамилии (Наличие цифр)
            for (int i = 0; i < lastName.Length; i++)
            {
                if (Char.IsDigit(lastName, i) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Error: Фамилия водителя автобуса №{idBus} содержит цифры!");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto inizialError;

                }
            }

        //проверка корректности И.О. (Наличие цифр)
        inizialError:;
            for (int i = 0; i < inizial.Length; i++)
            {
                if (Char.IsDigit(inizial, i) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Error: Инициалы водителя автобуса №{idBus} содержат цифры!");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto testErrorTest;

                }
            }
        testErrorTest:;

        }



        public int ID
        {
            get => id;// read only
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }

        }
        public string Inizials
        {
            get
            {
                return inizial;
            }
            set
            {
                inizial = value;
            }

        }
        public int BusNumber
        {
            get
            {
                return idBus;
            }
            set
            {
                if (value > 0)
                {
                    idBus = value;
                }
                idBus = value;
            }
        }

        public int LineNumber
        {
            get
            {
                return lineId;
            }
            private set //для одного из свойств ограните доступ по set
            {
                lineId = value;
            }
        }

        public string Brand
        {
            get
            {
                return brand;
            }

        }

        public int Exploit
        {
            get
            {
                return exp;
            }
            set
            {
                exp = value;
            }
        }

        public int Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                mileage = value;
            }

        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void GetBusInfo(Bus bus)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"GetBusInfo (Информация о автобусе №{bus.idBus}): ");
            Console.WriteLine($"id: {bus.id} \n" +
                $"lastName: {bus.lastName} \n" +
                $"inizials: {bus.inizial} \n" +
                $"brand:{brand} \n" +
                $"busNumber: {bus.idBus} \n" +
                $"tourNumber: {bus.lineId} \n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override string ToString()
        {
            Console.WriteLine("\nToString (значения строк):");
            return $"id: {ID} \n" +
                $"lastName: {LastName} \n" +
                $"inizials: {Inizials} \n" +
                $"brand:{brand} \n" +
                $"busNumber: {BusNumber} \n" +
                $"tourNumber: {lineId} \n";

        }

        public void GetBusAgeInfo(Bus bus)
        {

            Console.WriteLine($"Bus number: {bus.idBus}; Age: {bus.age}.")
             ;
        }
        public override bool Equals(object bus)
        {
            if (bus.GetType() != this.GetType()) return false;

            Bus person = (Bus)bus;
            return (this.LastName == person.LastName);
        }
    }
}
