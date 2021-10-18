using System;
using System.Collections.Generic;

namespace LR_04
{
    class LR_04
    {
        static void Main(string[] args)
        {
            /*Задание списка*/
            List<string> MyListOne = new List<string>() {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
            List<string> MyListTwo = new List<string>() { "One", "Five", "2.3"};
            List list1 = new List(MyListOne);
            List list2 = new List(MyListTwo);

            /*Реверс списка*/
            List test1 = !list1;
            /*Добавление списка b к списку a*/
            List test2 = list1 < list2;
            List test3 = list1 > list2;
            /*Объединение списков*/
            List test4 = list1 + list2;
        }
        
    }
}
