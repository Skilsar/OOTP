using System;

namespace LR_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus("Ivanov6", "A.A.", 6, 101, 2017, 5000, 12);
            Bus bus2 = new Bus("Petrov", "A.B.", 11, 202, 2018, 4000, 48);
            Bus bus3 = new Bus("Sidorov", "A.C.", 11, 303, 2019, 3000, 34);
            Bus bus4 = new Bus("Pupkin", "A9.D.", 45, 404, 2100, -1000, 3);
            Bus bus5 = new Bus("Igorekov", "A.E.", 24, 505, 2007, 120000, 18);


            Console.WriteLine(bus1.ToString());

            bus1.GetBusInfo(bus1);
            bus2.GetBusInfo(bus2);
            bus3.GetBusInfo(bus3);
            bus4.GetBusInfo(bus4);
            bus5.GetBusInfo(bus5);

            Console.WriteLine($"Age of buses:");

            bus1.GetBusAgeInfo(bus1);
            bus2.GetBusAgeInfo(bus2);
            bus3.GetBusAgeInfo(bus3);
            bus4.GetBusAgeInfo(bus4);
            bus5.GetBusAgeInfo(bus5);

            Arrays();


            Console.ReadKey();
        }

        public static void Arrays()
        {
            var Buses = new Bus[2];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\nСоздание массива объектов");
            Console.ForegroundColor = ConsoleColor.White;
            Buses[0] = new Bus("Vinny", "M.A.", 777, 601, 6, 2040, 12);
            Buses[1] = new Bus("Suvor", "A.A.", 555, 701, 5, 2070, 15);
            foreach (var i in Buses)
            {
                Console.WriteLine(i);
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (var bus in Buses)
                if (bus.LineNumber == 601)  //список автобусов для заданного номера маршрута;
                    Console.WriteLine($"Номер автобуса для заданного номера маршрута: {bus.BusNumber}");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (var bus in Buses)
                if (DateTime.Now.Year - bus.Exploit > 12)   //список автобусов, которые эксплуатируются больше заданного срока;
            Console.WriteLine($"Номер автобуса, который эксплуатируется больше заданного срока: {bus.BusNumber}");


            //анонимный тип 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nАнонимный тип. Задание и вывод параметров.");
            var busAnonimus = new { Name = "BOBBY", busNumber = 141, tourNumber = 25, exploit = 12, mileage = 2010 };
            Console.WriteLine($"Name:" + busAnonimus.Name + ";  " + "Bus number:" + busAnonimus.busNumber + ";  " + "Tour number:" + busAnonimus.tourNumber + ";  " + "Exploit:" + busAnonimus.exploit + ";  " + "Mileage:" + busAnonimus.mileage + ";  ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
