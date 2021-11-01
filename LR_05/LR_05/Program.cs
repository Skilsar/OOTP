using System;

namespace LR_05
{
    class LR_05
    {
        static void Main(string[] args)
        {
            Employee OneEmpl = new Employee("Павел", 21, "1sda@mm.ri", "1946837", "Директор", new DateTime(2017,09,12));
            Learner OneLearner = new Learner("Игорь", 19, "www.igor@igor.by", "934357679", "ПОИТ", new DateTime(2019,09,01));
            Working OneWork = new Working("Кирилл", 21, "barabul@bul.by", "375445698370", "Инженер", new DateTime(2018,10,10));
            Lathe OneLathe = new Lathe("Данила", 18, "daniil@ail.by", "3966337" , 4, new DateTime(2019,09,03));
            Student OneStudent = new Student("ManOne", 45, "no email", "no number", "BSTU", new DateTime(2017, 09, 01));
            PartTimeStudent TwoStudent = new PartTimeStudent("ManTwo", 33, "no email", "3337776", "БГСХА", new DateTime(2014,09,01));
            Programmer Gleb = new Programmer("Gleb", 19, "gleb.****@gmail.com", "256****00", "Backend", 5);

            OneWork.Info(); //вызов метода

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nПавел студент?:  " + (OneEmpl is Student));
            Console.WriteLine("Павел служащий?: " + (OneEmpl is Employee) + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            TwoStudent.ToString(); //вызов общего метода

            Printer printer = new Printer();
            printer.IAmPrinting(Gleb);  //возвращает значение полученное в результате выполнения ToString

            Console.WriteLine("------------------Вывод через массив------------------------------");
            Person[] persons = new Person[] { OneEmpl, OneLearner, OneWork, OneLathe, OneStudent, TwoStudent, Gleb};
            for (int i = 0; i < persons.Length; i++)
            {
                printer.IAmPrinting(persons[i]);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("=============================");
        }
    }
}
