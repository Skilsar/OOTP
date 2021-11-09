using System;
using System.Collections.Generic;
using static Lab_8.MyClass;
using static LR_08.GeneralClass;

namespace LR_08
{
    class LR_08
    {
        static void Main(string[] args)
        {

            /* 3. Использование обобщения для стандартных типов данных*/
            MySet<int> MySet1 = new MySet<int>(6);
            MySet<char> MySet2 = new MySet<char>(7);
            MySet<bool> MySet3 = new MySet<bool>(5);
            MySet<byte> MySet4 = new MySet<byte>(0);


            Console.WriteLine("Первое множество: ");
            MySet1.Add(1);
            MySet1.Add(2);
            MySet1.Add(3);
            MySet1.Add(4);
            MySet1.Add(5);
            MySet1.Add(6);
            MySet1.Show();

            Console.WriteLine("\nВторое множество: ");
            MySet2.Add('a');
            MySet2.Add('b');
            MySet2.Add('c');
            MySet2.Add('d');
            MySet2.Add('e');
            MySet2.Add('f');
            MySet2.Add('g');
            MySet2.Show();

            Console.WriteLine("\nТретье множество: ");
            MySet3.Add(true);
            MySet3.Add(false);
            MySet3.Add(false);
            MySet3.Add(true);
            MySet3.Add(true);
            MySet3.Show();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nУдаление элемента из множества");
            Console.ForegroundColor = ConsoleColor.Gray;
            MySet1.Delete(6);
            Console.Write("\nМножество 1 после удаления элементов: \n");
            MySet1.Show();
            MySet2.Delete('b');
            MySet2.Delete('c');
            Console.Write("\nМножество 2 после удаления элементов:\n");
            MySet2.Show();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nДобавление объектов\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            CollectionType<Person> collectiontype = new CollectionType<Person>(6);
            Person OneLearner = new Learner("Игорь", 19, "www.igor@igor.by", "934357679", "ПОИТ", new DateTime(2019, 09, 01));
            Person OneWork = new Working("Кирилл", 19, "barabul@bul.by", "375445698370", "Инженер", new DateTime(2018, 10, 10));
            collectiontype.Add(OneWork);
            collectiontype.Add(OneLearner);

            collectiontype.Show();

            WriteFunction<int>.WriteToFile(MySet1.setArr);
            WriteFunction<char>.WriteToFile(MySet2.setArr);
            WriteFunction<bool>.WriteToFile(MySet3.setArr);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Запись элементов в файл...\n");
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Вывод элементов из файла:\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            WriteFunction<int>.LoadFromFile();


            /*ЛР № 4*/

            /*Задание списка*/

            //List<int> MyListOne = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> MyListTwo = new List<int>() { 1, 5, 77 };
            //List<int> MyListThree = new List<int>() { 1, 5, 77 };

            //List list1 = new List(MyListOne);
            //List list2 = new List(MyListTwo);
            //List list3 = new List(MyListThree);

            ///*Реверс списка*/
            ////List test1 = !list1;

            ///*Добавление списка b к списку a*/
            //List test2 = list1 < list2;
            //List test3 = list1 > list2;

            /*Объединение списков*/
            //List test4 = list1 + list2;

            ///*Сравнение списков*/
            //List test5 = list2 != list3;

            ///*Задание парамертов для объекта списка*/
            //list1.Owner(1, "Gleb", "MyCompany");

            ///*Получение даты создания объекта*/
            //list1.Date();

            ///*Количестов элементов в списке*/
            //int ColOneList = StatisticOperation.numb(list1);

            ///*Сумма элементов списка*/
            //int SumOneListElem = StatisticOperation.sum(list2);

            ///*Находжение минимального и максимального элементов в списке*/
            //int MinMaxListElem = StatisticOperation.MM(list3);

            ///*Разница между максимальным и минимальным*/

            //int DiffListElem = StatisticOperation.MMDiff(list1);
        }

    }
}
