using System;
using System.Collections.Generic;
using System.Linq;

namespace LR_04
{
    class List
    {
        public List<int> list;
        public int ThisListNum;
        static int calcList;
        private DateTime DateTimeInfo;

        public List(List<int> newList)
        {
            this.list = newList;
            calcList++;
            this.ThisListNum = calcList;
            Console.WriteLine($"<--Значения списка #{this.ThisListNum}-->");
            Date();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i]);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static List operator !(List a)
        {
            a.list.Reverse();
            Console.WriteLine($"<--Инверсия списка #{a.ThisListNum}-->");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (int revers in a.list)
            {
                Console.WriteLine(revers);
            }
            Console.ForegroundColor = ConsoleColor.Gray;


            return a;
        }

        public static List operator <(List a, List b)
        {
            for (int i = 0; i < b.list.Count; i++)
            {
                a.list.Add(b.list[i]);
            }

            Console.WriteLine($"<--Добавление списка #{b.ThisListNum} к списку #{a.ThisListNum}-->");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int i = 0; i < a.list.Count; i++)
            {
                Console.WriteLine(a.list[i]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            return a;
        }

        public static List operator >(List a, List b)
        {
            for (int i = 0; i < a.list.Count; i++)
            {
                b.list.Add(a.list[i]);
            }

            Console.WriteLine($"<--Добавление списка #{a.ThisListNum} к списку #{b.ThisListNum}-->");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int i = 0; i < b.list.Count; i++)
            {
                Console.WriteLine(b.list[i]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            return a;
        }

        public static List operator +(List a, List b)
        {
            var sizeListA = a.list.Count;
            var sizeListB = b.list.Count;

            var result = a.list.Union(b.list);
            Console.WriteLine($"<--Объединение списков #{a.ThisListNum} и #{b.ThisListNum}-->");
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (int item in result)
                Console.WriteLine(item);
            Console.ForegroundColor = ConsoleColor.Gray;

            return a;
        }

        public static List operator ==(List a, List b)
        {
            Console.WriteLine($"<--Проверка равенства списков #{a.ThisListNum} и #{b.ThisListNum}-->");
            if (a.list.Count != b.list.Count)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Списки #{a.ThisListNum} и #{b.ThisListNum} не ровны по кол-ву элементов.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                int flag = 0;
                for (int i = 0; i < a.list.Count; i++)
                {
                    if (a.list[i] == b.list[i]) { }
                    else { flag++; }

                }
                if (flag != 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Элементы списков #{a.ThisListNum} и #{b.ThisListNum} не ровны.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Списки #{a.ThisListNum} и #{b.ThisListNum} абсолютно ровны");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

            }
            return a;
        }

        public static List operator !=(List a, List b)
        {
            Console.WriteLine($"<--Проверка равенства списков #{a.ThisListNum} и #{b.ThisListNum}-->");
            if (a.list.Count != b.list.Count)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Списки #{a.ThisListNum} и #{b.ThisListNum} не ровны по кол-ву элементов.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                int flag = 0;
                for (int i = 0; i < a.list.Count; i++)
                {
                    if (a.list[i] == b.list[i]) { }
                    else { flag++; }

                }
                if (flag != 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Элементы списков #{a.ThisListNum} и #{b.ThisListNum} не ровны.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Списки #{a.ThisListNum} и #{b.ThisListNum} абсолютно ровны");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

            }
            return a;
        }


        int id;
        string name;
        string company;

        public void Owner(int _id, string _name, string _company)
        {
            this.id = _id;
            this.name = _name;
            this.company = _company;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Списку #{this.ThisListNum} были заданы следующие параметры:\nID: {id}\nName: {name}\nCompany: {company}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Date()
        {
            this.DateTimeInfo = new DateTime();
            this.DateTimeInfo = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"\nДата создания списка #{this.ThisListNum}: {this.DateTimeInfo}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }

    static class StatisticOperation
    {
        public static int colvo(List a)
        {
            int col = a.list.Count;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nКоличество элементов в списке #{a.ThisListNum} = {col}\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            return col;
        } 

        public static int sum(List a)
        {
            int sumElement = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < a.list.Count; i++)
            {
                sumElement += a.list[i];
            }
            Console.WriteLine($"\nСумма элементов в списке #{a.ThisListNum} = {sumElement}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            
            return sumElement;
        }

        public static int MM(List a)
        {
            int maxElement = a.list[0];
            int minElement = a.list[0];
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < a.list.Count; i++)
            {
                //Ищем максимальный
                if (maxElement < a.list[i])
                {
                    maxElement = a.list[i];
                }
                //Ищем минимальный
                if (minElement > a.list[i])
                {
                    minElement = a.list[i];
                }
            }

            Console.WriteLine($"\nСписок #{a.ThisListNum}:\nМаксимальное значение = {maxElement};\nМинимальное значение = {minElement}\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            return maxElement + minElement;
        }

        public static int MMDiff(List a)
        {
            int maxElement = a.list[0];
            int minElement = a.list[0];
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < a.list.Count; i++)
            {
                //Ищем максимальный
                if (maxElement < a.list[i])
                {
                    maxElement = a.list[i];
                }
                //Ищем минимальный
                if (minElement > a.list[i])
                {
                    minElement = a.list[i];
                }
            }

            Console.WriteLine($"\nСписок #{a.ThisListNum}:\nРазница между минимальным и максимальным = {maxElement - minElement}");
            Console.ForegroundColor = ConsoleColor.Gray;

            return maxElement - minElement;
        }
    }
}
