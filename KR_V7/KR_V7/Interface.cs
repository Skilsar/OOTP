using System;
using System.Collections.Generic;
using System.Text;

namespace KR_V7
{

    interface ICan
    {
        void Speak(string message);
    }
    public class People:ICan
    {
        string name;
        public People(string name)
        {
            this.name = name;
            Console.WriteLine($"Создан объект с именем: {name}");
        }

        public void Speak(string message)
        {
            Console.WriteLine($"Объект {this.name} говорит: {message}");
        }
    }

    internal static class Orator
    {
        static public void Checker(People a)
        {
            if (a is ICan)
            {
                Console.WriteLine($"Интефрейс поддерживается!\n Введите текст сообщения");
                string message = Console.ReadLine();
                a.Speak(message);
            }
            else
            {
                Console.WriteLine($"Интефрейс не поддерживается!");

            }
        }
    }
}
