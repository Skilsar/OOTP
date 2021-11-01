using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LR_07
{
    interface IPerson
    {
        void Info();
    }

    public class Person : IPerson
    {
        public string Name;
        protected int Age;
        protected string Email;
        protected string Number;
        protected readonly int id;
        public List<Person> AllPerson;

        public void TestNumber(Person x)
        {
            int NumSize = x.Number.Length;
            bool flag = false;
            if (NumSize < 7 || NumSize > 13)
            {
                flag = false;
            }
            else flag = true;
            Debug.Assert(flag, "Возможно номер телефона введен некорректно");
        }

        public virtual void Info() { Console.WriteLine(this.Name); }
        public void AddPerson(Person a) { AllPerson.Add(a); }
        public void DelPerson(Person a) { AllPerson.Remove(a); }

        public void ShowList()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n" + "Список Персон: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (Person elem in AllPerson)
            {
                Console.WriteLine(elem.ToString());
            }
        }

        public int GetStudentsAmount()  //количество студентов в списке
        {
            int amount = 0;
            foreach (Person item in AllPerson)
            {
                if (item is Student) { amount++; }
            }
            Console.WriteLine($"\nКоличество студентов: {amount}\n");
            return amount;
        }

        public void SortPerson()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nСортировка по возрасту!");
            Console.ForegroundColor = ConsoleColor.Gray;
            AllPerson = AllPerson.OrderBy(w => w.Age).ToList();
        }

        public void FindProgrammer()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nFind programmer in List.");
            Console.ForegroundColor = ConsoleColor.Gray;
            List<Person> programmer = new List<Person>(10);
            int amount = 0;
            foreach (Person item in AllPerson)
            {
                if (item is Programmer)
                {
                    Console.WriteLine($"Программист #{amount + 1}");
                    Console.WriteLine(item.ToString());
                    amount++;
                }
            }
            Console.WriteLine($"Количество программистов: {amount}");
        }

        public Person(string Name, int Age, string Email, string Number)
        {
            if (Name.Length <= 3 || Name.Length >= 20)
            {
                throw new ErrorName("Недопустимое значение имени", Name);
            }
            else 
            this.Name = Name;
            if (Age <= 1 || Age > 100)
            {
                throw new ErrorAge("Недопустимое значение возраста", Age);
            }
            this.Age = Age;
            this.Email = Email;
            this.Number = Number;
            id = (int)id.GetHashCode() + (int)Name.GetHashCode();
        }

        public Person()
        {
            this.AllPerson = new List<Person>(10);
        }

        public override string ToString() // переопределение с выводом инфы
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\nEmail: {Email};\nНомер телефона: {Number}\nВозраст: {Age};");
            Console.ForegroundColor = ConsoleColor.Gray;
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            return this.Name == ((Person)obj).Name;
        }
        public override int GetHashCode()
        {
            int hash = 47, d = 32;
            string a = Convert.ToString(Name);
            hash = string.IsNullOrEmpty(a) ? 0 : Name.GetHashCode();
            hash = (hash * 47) + d.GetHashCode();
            return hash;
        }
    }

    //Служащий
    sealed class Employee : Person, IPerson
    {
        private string IEmployee;       //Должность
        private DateTime DateEmployment;//Дата вступления в должность

        public Employee(string Name, int Age, string Email, string Number, string IEmployee, DateTime DateEmployment)
            : base(Name, Age, Email, Number)
        {
            this.DateEmployment = DateEmployment;
            this.IEmployee = IEmployee;
        }
        public override void Info()
        {

            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\nEmail: {Email};\nНомер телефона: {Number};\n" +
                $"Должность: {IEmployee};\nДата вступления в должность: {DateEmployment}");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            string Info = $"Должность: {IEmployee};\nДата принятия на должность: {DateEmployment}\nВозраст: {Age};";
            Console.ForegroundColor = ConsoleColor.Gray;
            return Info;
        }
    }

    //Обучающийся
    sealed class Learner : Person, IPerson
    {
        private string Special;         //Специальность
        private DateTime DateLearner;   //Дата начала обучения

        public Learner(string Name, int Age, string Email, string Number, string Special, DateTime DateLearner)
            : base(Name, Age, Email, Number)
        {
            this.Special = Special;
            this.DateLearner = DateLearner;
        }
        public override void Info()
        {
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\nEmail: {Email};\nНомер телефона: {Number};\n" +
                $"Специальность: {Special};\nДата начала обучения: {DateLearner}");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            return ($"Специальность: {Special};\nДата начала обучения: {DateLearner};\nВозраст: {Age};");
        }
    }

    //Работающий
    sealed class Working : Person, IPerson
    {
        private string Special;         //Специальность
        private DateTime DateWorking;   //Дата начал труда

        public Working(string Name, int Age, string Email, string Number, string Special, DateTime DateWorking)
            : base(Name, Age, Email, Number)
        {
            this.Special = Special;
            this.DateWorking = DateWorking;
        }
        public override void Info()
        {
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\nEmail: {Email};\nНомер телефона: {Number};\n" +
                $"Специальность: {Special};\nДата начала труда: {DateWorking}");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            return ($"Имя: {Name};\nСпециальность: {Special};\nДата начала труда: {DateWorking}\nВозраст: {Age};");
        }
    }



    //Токарь
    sealed class Lathe : Person, IPerson
    {
        private int IClass;   //Разряд
        private DateTime DateWorking;   //Дата начал труда

        public Lathe(string Name, int Age, string Email, string Number, int IClass, DateTime DateWorking)
            : base(Name, Age, Email, Number)
        {
            this.IClass = IClass;
            this.DateWorking = DateWorking;
        }
        public override void Info()
        {
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\nEmail: {Email};\nНомер телефона: {Number};\n" +
                $"Разряд токаря: {IClass}; \nДата начала труда: {DateWorking}");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            return ($"Имя: {Name};\nРазряд токаря: {IClass};\nВозраст: {Age};");
        }
    }



    sealed class Student : Person, IPerson
    {
        private string University;
        private DateTime iDate;

        public Student(string Name, int Age, string Email, string Number, string University, DateTime iDate)
            : base(Name, Age, Email, Number)
        {
            this.University = University;
            this.iDate = iDate;
        }
        public override void Info()
        {
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\nEmail: {Email};\nНомер телефона: {Number};\n" +
                $"Университет: {University};\nДата поступления: {iDate}");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            return ($"Имя: {Name};\nУниверситет: {University};\nДата поступления: {iDate}\nВозраст: {Age};");
        }
    }



    sealed class PartTimeStudent : Person, IPerson
    {
        private string University;
        private DateTime iDate;

        public PartTimeStudent(string Name, int Age, string Email, string Number, string University, DateTime iDate)
            : base(Name, Age, Email, Number)
        {
            this.University = University;
            this.iDate = iDate;
        }
        public override void Info()
        {
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\nEmail: {Email};\nНомер телефона: {Number};\n" +
                $"Университет: {University};\nДата поступления: {iDate}");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            var result = ($"Университет: {University};\nДата поступления: {iDate}\nВозраст: {Age};");
            Console.ForegroundColor = ConsoleColor.Gray;
            return result;

        }
    }


    sealed class Programmer : Person, IPerson
    {
        private string ProgreammerTypes; //тип программиста
        private int Exp;                 //стаж

        public Programmer(string Name, int Age, string Email, string Number, string ProgreammerTypes, int Exp)
            : base(Name, Age, Email, Number)
        {
            this.ProgreammerTypes = ProgreammerTypes;
            if (Exp <= 0 || Exp >= 60 || Exp >= Age)
            {
                throw new ProgrammerExpError("Ошибка значения Стажа программиста", Exp);
            }
            this.Exp = Exp;
        }
        public override void Info()
        {
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\nEmail: {Email};\nНомер телефона: {Number};\n" +
                $"Категория программиста: {ProgreammerTypes};\nСтаж работы: {Exp}");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            return ($"Имя: {Name};\nКатегория программиста: {ProgreammerTypes};\nСтаж работы: {Exp}\nВозраст: {Age};");
        }
    }

    public class Printer
    {
        public void IAmPrinting(Person value)
        {
            Console.WriteLine(value.ToString());
        }
    }
}
