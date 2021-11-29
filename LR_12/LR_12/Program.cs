using LR_12;
using System;
using System.IO;

namespace LR_12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ClearFile();
            First();
            Second();
            Third();
        }
        private static void First()
        {
            /*1. Для изучения .NET Reflection API напишите статический класс Reflector,
                который собирает информацию и будет содержать методы выполняющие
                исследования класса (принимают в качестве параметра имя класса) и
                записывающие информацию в файл (формат тестовый, json или xml):
            a. Определение имени сборки, в которой определен класс;
            b. есть ли публичные конструкторы;
            c. извлекает все общедоступные публичные методы класса
                (возвращает IEnumerable<string>);
            d. получает информацию о полях и свойствах класса (возвращает
            IEnumerable<string>);
            e. получает все реализованные классом интерфейсы (возвращает
            IEnumerable<string>);
            f. выводит по имени класса имена методов, которые содержат
            заданный (пользователем) тип параметра (имя класса передается
                в качестве аргумента);
            g. метод Invoke, который вызывает метод класса, при этом значения
            для его параметров необходимо
             1) прочитать из текстового файла
                (имя класса и имя метода передаются в качестве аргументов) 
             2) сгенерировать, используя генератор значений для каждого типа.
           Пара     метрами метода Invoke должны быть : объект, имя метода,
                массив параметров.*/

            File.WriteAllText("Reflection.txt", String.Empty);

            Reflector.WriteAssemblyName("LR_12.Reflector");
            Reflector.WriteIsAnyPublicConstruction("LR_12.Reflector");
            Reflector.WritePublicMethods("LR_12.Reflector");
            Reflector.WriteMethodsWithUserParametr("LR_12.Reflector", "currentClassName");
            Reflector.Invoke("LR_12.Sum", "Summa");
        }

        private static void Second()
        {

            /*Продемонстрируйте работу «Рефлектора» для исследования типов на созданных
                вами классах не менее двух (предыдущие лабораторные работы) и стандартных
            классах .Net.*/

            //Для рефлексии файлов других сборок нужно подключить эти сборки в проект,а затем подключить их namespace

            Reflector.WriteAssemblyName("LR_12.Bus, LR_12");
            Reflector.WriteIsAnyPublicConstruction("LR_12.Bus, LR_12");
            Reflector.WritePublicMethods("LR_12.Bus, LR_12");
            Reflector.WriteMethodsWithUserParametr("LR_12.Bus, LR_12", ""); //par:brand

            Reflector.WriteAssemblyName("System.Object");
            Reflector.WriteIsAnyPublicConstruction("System.Object");
            Reflector.WritePublicMethods("System.Object");
            Reflector.WriteMethodsWithUserParametr("System.Object", "");


        }

        private static void Third()
        {
            /*2. Добавьте в Reflector обобщенный метод Create, который создает объект
            переданного типа (на основе имеющихся публичных конструкторов) и возвращает
            его пользователю.*/
            var sum = Reflector.Create("LR_12.Sum");
            Console.WriteLine(sum is Sum);
        }

        static void ClearFile()
        {
            var fileForInfortmation = new StreamWriter(@"E:\БГТУ\ООП\OOTP\LR_12\LR_12\Reflection.txt", false);

            fileForInfortmation.Close();
        }
    }
}
