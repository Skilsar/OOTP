using System;
using System.Collections.Generic;
using System.Linq;

namespace LR_04
{
    class List
    {
        private List<string> list;
        private int ThisListNum;
        static int calcList;

        public List(List<string> newList)
        {
            this.list = newList;
            calcList++;
            this.ThisListNum = calcList;
            Console.WriteLine($"<--Значения списка #{this.ThisListNum}-->");
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
            foreach (string revers in a.list)
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
            foreach (string item in result)
                Console.WriteLine(item);
            Console.ForegroundColor = ConsoleColor.Gray;

            return a;
        }

        public static List operator ==(List a, List b)
        {
            return a;
        }

        public static List operator !=(List a, List b)
        {
            return a;
        }

    }


}
