using System;
using System.Runtime.InteropServices.ComTypes;

namespace LR_2
{
    class Val
    {
        static void Main(string[] args)
        {
            repeat_home:  Console.Write("\nВведите номер задания: ");
            int ex = Convert.ToInt32(Console.ReadLine());
            switch (ex)
            {
                case 1:
                    ex_one();
                break;
                case 2:
                    ex_two();
                break;
                case 3:
                    ex_three();
                break;
                case 4:
                    ex_four();
                break;
                case 5:
                    /*Формальные параметры функции – массив целых и строка. Функция должна вернуть кортеж, 
                    содержащий: максимальный и минимальный элементы массива, 
                    сумму элементов массива и первую букву строки .*/

                    (int max, int min, int sum, char firstLetter) tuple;
                    int[] array = { 1, 2, 3, 4, 5, 777, -1, 700 };
                    string name = "Cardinal";
                    tuple = ex_five(array, name);
                    Console.WriteLine($"Max num: {tuple.max}\n" +
                                      $"Min num: {tuple.min}\n" +
                                      $"Sum: {tuple.sum}\n" +
                                      $"First letter: {tuple.firstLetter}");

                break;
                case 6:
                    /*A) Определите две локальные функции.
                    B) Разместите в одной из них блок checked, в котором определите переменную типа int с максимальным возможным значением этого типа. 
                    Во второй функции определите блок unchecked с таким же содержимым.
                    C) Вызовите две функции. Проанализируйте результат.*/
                    ex_six_checked();
                    ex_six_unchecked();
                break;
                default:
                    Console.WriteLine("Такоого задания нет! \nПопробуйте еще раз!");
                goto repeat_home;
            }
        }

        static void ex_one()
        {
            //Примитивные типы данных
            Console.WriteLine("Типы данных");
            //Целочисленные
            byte val1 = 127;
            sbyte val2 = -128;
            short val3 = -32768;
            ushort val4 = 65535;
            int val5 = -2147483648;
            uint val6 = 4294967295;
            long val7 = -9223372036854775808;
            ulong val8 = 9223372036854775807;
            //С плавающей запятой
            float val9 = 5_5;
            double val10 = 134.45E-2f;
            decimal val11 = 1.5E2m;
            //Символьные типы
            char val12 = 'G';
            string val13 = "Gleb Hlystov";
            //Логический тип
            bool val14 = true;
            //Особые типы
            object val15 = "Gleb";
            dynamic val16 = 1E3M;
            Console.WriteLine($"Значение: {val15}\n");

            //Преобразования типов
            Console.WriteLine("Преобразования типов");
            //Неявное преобразование
            char conv = 'H';
            int conv1 = conv;
            long conv2 = conv1;
            float conv3 = conv2;
            double conv4 = conv3;
            Console.WriteLine(conv4);

            //Явное преобразование
            double conv5 = 72.4;
            float conv6 = (float)conv5;
            long conv7 = (long)conv6;
            int conv8 = (int)conv7;
            char conv9 = (char)conv8;
            Console.WriteLine($"{conv9}\n");

            int co = 10;
            double co1 = 5.25;
            bool co2 = true;
            //Конвертация с использованием Convert
            Console.WriteLine(Convert.ToString(co));       // int в string
            Console.WriteLine(Convert.ToDouble(co));       // int в double
            Console.WriteLine(Convert.ToInt32(co1));       // double в int
            Console.WriteLine(Convert.ToString($"{co2}\n"));      // bool в strin

            //Упаковка 
            Console.WriteLine("Упаковка/Распаковка типов данных");
            int Pack = 5;
            object NewPack = Pack;
            Console.WriteLine(NewPack);
            double Pack2 = 17.92;
            object NewPack2 = Pack2;

            //Распаковка
            double Unpack = (int)(double)NewPack2;
            Console.WriteLine(Unpack);

            var a = 3; // компилируется как int

            var NickName = "G.Cardinal"; // компилируется как string

            var flag = true; // компилируется как bool

            //flag = "G.Cardinal";  //переменная типа var сама определеляет тип необходиммой переменной (синтаксический сахар)

            // операции с неявно типизированной переменной
            Console.WriteLine("\nОперации с неявно типизированной переменной + Type Nulled (T?)\n");
            if (flag) Console.WriteLine(NickName + "— NickName for CyberForums!");


            // Nullable
            /* Если после типа переменной поставить ?
             * то это означает что эта переменная может
             * принимат значение null;
             */
            double? nvd1 = 18.09;
            //double nvd2 = nvd1; // error //нельзя присвоить Nulled обычному типу 

            double nvd3 = (double)nvd1;

            Console.WriteLine(nvd3);

            // если после переменной поставить ??, то она будет проверяться
            // на null значение, и если оно = Null, оно вернёт значение
            // указанное после ?? или выполнит код ...

            string? MyName = null;
            Console.WriteLine(MyName ?? "Cardinal");
        }

        static void ex_two()
        {
            string str1 = "Hello, ";
            string str2 = "my name is ";
            string str3 = "Gleb";

            Console.WriteLine(str1 == str2); // false
            Console.WriteLine(str1 == str3); // true

            str1 += str2; // сцепление

            Console.WriteLine($"Сцепление: \n {str1}");

            string str4 = str3; // копирование

            Console.WriteLine($"Копирование: \n {str4}");

            string word = str1.Substring(0, 5); // выделение подстроки и её копирование

            Console.WriteLine($"Выделение подстроки и копирование: {word}");

            string[] words = str2.Split(); // разделение строки на слова
            Console.WriteLine($"Разделение строки на слова: {words[1]}"); // output: name

            // вставка в определенную позицию
            string message = "вставка в определенную позицию: Hello, ";
            string name = "Cardinal";
            Console.WriteLine(message.Insert(message.Length, name)); //(1 параметр = место инсерта, 2 что вставить)

            // удаление
            string text = "I DON`T LOVE OOP";
            Console.WriteLine($"Удаление слова: {text.Remove(2, 6)}");
            Console.WriteLine($"Замена слова: {text.Replace("DON`T", "VERY")}");
            // интерполирование строк
            var lng = "This is C# language.";
            Console.WriteLine($"Интерполяция строк: Hello, {name}! {lng}");

            //пустая и нулевая строки
            string val1 = null;
            string val2 = String.Empty;
            string val3 = "Cardinal";
            //простейший пример использования isNullOrEmpty
            //null вернет true, empty - false
            Console.WriteLine($"Использование ф-ции isNullOrEmpty:");
            if (String.IsNullOrEmpty(val1)) Console.WriteLine("This string is null or empty");
            else Console.WriteLine("Noooooooo!");
            if (String.IsNullOrEmpty(val2)) Console.WriteLine("This string is null or empty");
            else Console.WriteLine("Noooooooo!");
            if (String.IsNullOrEmpty(val3)) Console.WriteLine("This string is null or empry");
            else Console.WriteLine("This string is normal string. No Null or Empty");


            // STRING BUILDER
            Console.WriteLine("\n---STRING BUILDER---\n");

            var sb = new System.Text.StringBuilder();

            for (int i = 0; i < 10; i++)                                    /////////////////////!!!!!!!!!!!!!!!
                sb.Append(i);

            Console.WriteLine(sb.ToString()); // 0123456789

            sb[0] = sb[3]; // with string we cant do this

            Console.WriteLine(sb.ToString()); // 3123456789
        }

        static void ex_three()
        {
            int[,] mas = { { 1, 2, 3 }, { 3, 2, 1 }, { 4, 5, 6 } }; //задание массива [двухмерный, т.к. 1 ',']

            for (int i = 0; i < 3; i++)     //вывод элементов массива перебором
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{mas[i, j]}\t");
                }
                Console.Write("\n");
            }

            string[] str_array = { "Hello", "My name is", "Cardinal", "I love OOP!"}; //задание неограниченного массива
            Console.WriteLine("Содержание массива:");
            for (int i = 0; i < str_array.Length; i++)          //вывод массива
                Console.WriteLine($"[{i}]. {str_array[i]}");

            repeat:
            Console.WriteLine("Выберите номер строки, которую хотите заменить: ");      //определение номера строки для изменения
            int a = System.Convert.ToInt32(Console.ReadLine());

            if (a < str_array.Length) //проверка: входит ли в массив введенное число
            {
                Console.WriteLine("Напишите текст: ");
                string answer = Console.ReadLine(); //запомнить
                str_array[a] = answer;              //заменить
                for (int i = 0; i < str_array.Length; i++)  //вывести
                    Console.WriteLine($"[{i}]. {str_array[i]}");
            }
            else
            {
                Console.WriteLine("Вы ввели неправильное число! \nПопробуйте еще раз!");
                goto repeat;
                
            }

            byte MasSize = 4;
            int[][] array = new int[MasSize][];

            for (int i = 0; i < MasSize; i++)
            {
                array[i] = new int[i + 1];
                Console.WriteLine($"заполните массив {i} из {MasSize - 1}");
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nИтоговый ступеньчетый массив:\n");

            for (int i = 0; i < MasSize; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}\t");
                }
                Console.Write("\n");
            }


            var Mas_Two = new[] { 1, 2, 3, 4 };       // неявно типизированный массив чисел
            var Mas_Three = new[] { "one", "two" };  // неявно типизированная 

        }

        static void ex_four()
        {
            // Ex. 4 A)
            (int, string, char, string, ulong) tuple = (17, "STR", 'C', "MyTEXT", 777);
            // Ex. 4 B)
            Console.WriteLine(tuple);
            Console.WriteLine($"{tuple.Item1} {tuple.Item3} {tuple.Item5}");
            // Ex. 4 C)
            string MyName;
            int MyAge;

            (string name, ushort age) man = ("G.Cardinal", 19);

            MyName = man.name;
            MyAge = man.age; // from ushort to int without less memory

            (MyName, _, _) = tuplesReturn(); // deconstruction of tuple

            Console.WriteLine(man== ("G.Cardinal", 19)); // true
            Console.WriteLine(man == ("B.Kirill", 19)); // false

        }

        static (string, ushort, char) tuplesReturn() // return info (string name, ushort age, char sex)
        {
            return ("Kirill", 19, 'm');
        }

        static (int max, int min, int sum, char firstLetter) ex_five(int[] a, string str)
        {

            if ((a is null || a.Length == 0) || (str is null || str.Length == 0))
            {
                throw new ArgumentException("Массив или строка пусты!");
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;

            foreach (int i in a)
            {
                sum += i;

                if (i < min)
                {
                    min = i;
                }

                if (i > max)
                {
                    max = i;
                }
            }

            char letter = str[0];

            return (max, min, sum, letter);
        }

         static void ex_six_checked()
        {
            checked
            {
                int i = int.MaxValue;
            }
        }

        static void ex_six_unchecked()
        {
            unchecked
            {
                int i = int.MaxValue;
            }
        }
    }

}
