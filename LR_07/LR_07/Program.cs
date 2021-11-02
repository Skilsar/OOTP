using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LR_07

{
    partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Работа с сообственными исключениями!\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                //Проверка правильности Имени
                try
                {
                    Employee OneEmpl = new Employee("Пав", 0, "1sda@mm.ri", "1946837", "Директор", new DateTime(2017, 09, 12));

                }
                catch (ErrorName ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                    Logger.WriteLog(ex);
                }

                //Проверка правильности Возраста
                try
                {
                    Employee OneEmpl = new Employee("Павел", 0, "1sda@mm.ri", "1946837", "Директор", new DateTime(2017, 09, 12));

                }
                catch (ErrorAge ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                    Logger.WriteLog(ex);
                }

                //Проверка стажа программиста
                try
                {
                    Programmer OneProger = new Programmer("Vasya", 37, "random@mail.m", "1234567", "FullStack", 40);
                }
                catch (ProgrammerExpError ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                    Logger.WriteLog(ex);
                }

                Learner OneLearner = new Learner("Игорь", 19, "www.igor@igor.by", "934357679", "ПОИТ", new DateTime(2019, 09, 01));
                Working OneWork = new Working("Кирилл", 19, "barabul@bul.by", "375445698370", "Инженер", new DateTime(2018, 10, 10));
                Lathe OneLathe = new Lathe("Данила", 18, "daniil@ail.by", "3966337", 4, new DateTime(2019, 09, 03));
                Student OneStudent = new Student("ManOne", 45, "no email", "no number", "BSTU", new DateTime(2017, 09, 01));
                Student TwoStudent = new Student("ManTwo", 31, "bigemail@m.ru", "my number is big secret", "BGUIR", new DateTime(2018, 09, 01));
                Student ThreeStudent = new Student("ManThree", 36, "small_email@m.ru", "7638934", "BGU", new DateTime(2016, 09, 01));
                PartTimeStudent OneTimeStudent = new PartTimeStudent("ManTwo", 33, "no email", "3337776", "БГСХА", new DateTime(2014, 09, 01));
                Programmer User1 = new Programmer("TopSecret", 19, "VeryBigSecret@gmail.com", "256****00", "Backend", 5);

                Person AllPerson = new Person();
                Person[] PersonList = new Person[] {ThreeStudent, OneStudent, TwoStudent};

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nРабота со стандартными исключениями!");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\nЗапрос к несуществующему элементу = Вызов стандартного исключения IndexOutOfRangeException для несуществующего индекса.\n");
                try
                {
                    Console.WriteLine(PersonList[4].ToString());
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                    Logger.WriteLog(ex);
                }

                Console.WriteLine("\nПопытка недопустимого преобразования типов (Стан. фун. InvalidCastException)\n");
                try
                {
                    object obj = OneStudent.Name;
                    int Name = (char)obj;
                }
                catch (InvalidCastException ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                    Logger.WriteLog(ex);
                }

                Working TwoWork = new Working("2Worker", 19, "456765456@bul.by", "375445698370333", "Инженер", new DateTime(2018, 10, 10));

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nИспользование Debug.Assert");
                Console.ForegroundColor = ConsoleColor.Gray;
                AllPerson.TestNumber(TwoWork); //При значении TwoWork происходит ошибка и завершение работы программы

                //AllPerson.AddPerson(OneWork);    //19
                //AllPerson.AddPerson(OneStudent); //45
                //AllPerson.AddPerson(TwoStudent); //31
                //AllPerson.AddPerson(User1);      //19

                //AllPerson.GetStudentsAmount();

                //AllPerson.ShowList();

                //AllPerson.SortPerson();
                //AllPerson.ShowList();

                //AllPerson.FindProgrammer();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                Logger.WriteLog(ex);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n<!--Работа программы завершена!-->");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        }
    }
}