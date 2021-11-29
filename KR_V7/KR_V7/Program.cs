using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace KR_V7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1A
            string str1 = "123456789";
            string str2 = str1.Substring(2, 5);
            Console.WriteLine(str2);
            //1Б
            List<string> mystr = new List<string> {"One", "Two", "Three"};
            foreach(string el in mystr)
            {
                Console.WriteLine(el);
            }
            //2
            Date d1 = new Date(18, 09, 2002);
            Date d2 = new Date(19, 09, 2002);
            d1.ToString();
            //d1.GetHashCode();
            //d2.GetHashCode();
            d2.Srav(d1);
            //3
            People p1 = new People("One");
            p1.Speak("My message");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nПроверка поддержки интерфейса");
            Console.ForegroundColor = ConsoleColor.Gray;
            Orator.Checker(p1);
        }

        partial class Date
        {
            public int day;
            public int month;
            public int year;

            public Date(int day, int month, int year) {
                if (day > 31 || day < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введено неверное значения Дня");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    this.day = day;
                    Console.WriteLine($"\nДень: {this.day}");
                }
                if (month > 12 || month < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введено неверное значения Месяца");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    this.month = month;
                    Console.WriteLine($"Месяц: {this.month}");
                }
                if (year > 2021 || year < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введено неверное значения Года\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    this.year = year;
                    Console.WriteLine($"Год: {this.year}\n");
                }

            }

        }

        partial class Date
        {
            public override string ToString()
            {
                if (day == 0 || month == 0 || year == 0)
                {
                    Console.WriteLine("ToString: Значение даты неверно!");
                    return "Значение даты неверно!";
                }
                else
                {
                    string myDate = ($"Дата: {day}.{month}.{year}");
                    Console.WriteLine(myDate);
                    return myDate;
                }
            }

            public override int GetHashCode()
            {
                if (day == 0 || month == 0 || year == 0)
                {
                    Console.WriteLine("GetHashCode: Значение даты неверно!");
                    return 0;
                }
                else
                {
                    int hash = day * month / year + base.GetHashCode();
                    Console.WriteLine($"GetHashCode: {hash}");
                    return hash;
                }

            }

            public string Srav(Date a2)
            {
                int hash1 = this.GetHashCode();
                int hash2 = a2.GetHashCode();
                if (hash1 > hash2)
                {
                    string result = "Hash1 > Hash 2";
                    Console.WriteLine(result);
                    return result;
                }
                else
                {
                    string result = "Hash1 < Hash 2";
                    Console.WriteLine(result);
                    return result;
                }
            }
        }

    }
}
