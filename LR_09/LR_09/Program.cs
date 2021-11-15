using System;

namespace LR_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero HeroOne = new Hero(1000, "HeroOne");
            Undead UndeadOne = new Undead(300, "Sceleton");
            HeroOne.Attack();
            UndeadOne.Health();


            Console.WriteLine("\n------------Работа со строками---------------\n");

            string str = "Работа со строками, и как бы да, но нет, когда всегда...";
            Console.WriteLine("Исходная строка: " + str);
            Func<string, string> A = null;
            A = ChangeString.Remove;
            Console.WriteLine("Без знаков препинания: {0}", A(str));
            A = ChangeString.AddToString;
            Console.WriteLine("Добавление строки: {0}", A(str));
            A = ChangeString.Upper;
            Console.WriteLine("Заглавные буквы: {0}", str = A(str));
            A = ChangeString.Lower;
            Console.WriteLine("Прописные: {0}", A(str));
        }
    }
}
