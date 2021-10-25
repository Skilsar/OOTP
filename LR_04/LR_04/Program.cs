using System;
using System.Collections.Generic;

namespace LR_04
{
    class LR_04
    {
        static void Main(string[] args)
        {
            /*Задание списка*/
            //List<string> MyListOne = new List<string>() { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            //List<string> MyListTwo = new List<string>() { "One", "Five", "2.3" };
            //List<string> MyListThree = new List<string>() { "One", "Five", "2.3" };

            List<int> MyListOne = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> MyListTwo = new List<int>() { 1, 5, 77 };
            List<int> MyListThree = new List<int>() { 1, 5, 77 };

            List list1 = new List(MyListOne);
            List list2 = new List(MyListTwo);
            List list3 = new List(MyListThree);

            /*Реверс списка*/
            //List test1 = !list1;

            /*Добавление списка b к списку a*/
            //List test2 = list1 < list2;
            //List test3 = list1 > list2;

            /*Объединение списков*/
            //List test4 = list1 + list2;

            /*Сравнение списков*/
            List test5 = list2 != list3;

            /*Задание парамертов для объекта списка*/
            list1.Owner(1, "Gleb", "MyCompany");

            /*Получение даты создания объекта*/
            list1.Date();

            /*Количестов элементов в списке*/
            int ColOneList = StatisticOperation.colvo(list1);

            /*Сумма элементов списка*/
            int SumOneListElem = StatisticOperation.sum(list2);

            /*Находжение минимального и максимального элементов в списке*/
            int MinMaxListElem = StatisticOperation.MM(list3);

            /*Разница между максимальным и минимальным*/

            int DiffListElem = StatisticOperation.MMDiff(list1);
        }

    }
}
