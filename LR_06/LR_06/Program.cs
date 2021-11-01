using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LR_06
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Employee OneEmpl = new Employee("Павел", 21, "1sda@mm.ri", "1946837", "Директор", new DateTime(2017, 09, 12));
            Learner OneLearner = new Learner("Игорь", 19, "www.igor@igor.by", "934357679", "ПОИТ", new DateTime(2019, 09, 01));
            Working OneWork = new Working("Кирилл", 19, "barabul@bul.by", "375445698370", "Инженер", new DateTime(2018, 10, 10));
            Lathe OneLathe = new Lathe("Данила", 18, "daniil@ail.by", "3966337", 4, new DateTime(2019, 09, 03));
            Student OneStudent = new Student("ManOne", 45, "no email", "no number", "BSTU", new DateTime(2017, 09, 01));
            Student TwoStudent = new Student("ManTwo", 31, "bigemail@m.ru", "my number is big secret", "BGUIR", new DateTime(2018, 09, 01));
            Student ThreeStudent = new Student("ManThree", 36, "small_email@m.ru", "7638934", "BGU", new DateTime(2016, 09, 01));
            PartTimeStudent OneTimeStudent = new PartTimeStudent("ManTwo", 33, "no email", "3337776", "БГСХА", new DateTime(2014, 09, 01));
            Programmer User1 = new Programmer("TopSecret", 19, "VeryBigSecret@gmail.com", "256****00", "Backend", 5);

            Person AllPerson = new Person();
            AllPerson.AddPerson(OneEmpl);    //21
            AllPerson.AddPerson(OneWork);    //19
            AllPerson.AddPerson(OneStudent); //45
            AllPerson.AddPerson(TwoStudent); //31
            AllPerson.AddPerson(User1);      //19

            AllPerson.GetStudentsAmount();

            AllPerson.ShowList();

            AllPerson.SortPerson();
            AllPerson.ShowList();

            AllPerson.FindProgrammer();
        }


    }
}