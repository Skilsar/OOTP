using System;
using System.Collections.Generic;
using System.Text;

namespace LR_05
{
    interface IPerson
    {
        void Info();
    }

    public abstract class Person : IPerson
    {
        protected string Name;
        protected int Age;
        protected string Email;
        protected string Number;
        protected readonly int id;

        public Person(string Name, int Age, string Email, string Number)
        {
            this.Name = Name;
            this.Age = Age;
            this.Email = Email;
            this.Number = Number;
            id = (int)id.GetHashCode() + (int)Name.GetHashCode();
        }

        public override string ToString() // переопределение с выводом инфы
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\nEmail: {Email};\nНомер телефона: {Number}");
            Console.ForegroundColor = ConsoleColor.Gray;
            return " type " + base.ToString();

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
        public abstract void Info();
    }

    //Служащий
    sealed class Employee : Person, IPerson
    {
        private string IEmployee;       //Должность
        private DateTime DateEmployment;//Дата вступления в должность

        public Employee(string Name, int Age, string Email, string Number, string IEmployee, DateTime DateEmployment)
            : base (Name, Age, Email, Number)
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
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string Info = $"Должность: {IEmployee};\nДата принятия на должность: {DateEmployment}";
            //Console.WriteLine(Info);
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
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return ($"Специальность: {Special};\nДата начала обучения: {DateLearner}");
            Console.ForegroundColor = ConsoleColor.Gray;
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
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return ($"Специальность: {Special};\nДата начала труда: {DateWorking}");
            Console.ForegroundColor = ConsoleColor.Gray;
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
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return ($"Имя: {Name};\nРазряд токаря: {IClass};");
            Console.ForegroundColor = ConsoleColor.Gray;
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
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return ($"Университет: {University};\nДата поступления: {iDate}");
            Console.ForegroundColor = ConsoleColor.Gray;
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
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            var result =($"Университет: {University};\nДата поступления: {iDate}");
            //Console.WriteLine(result);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
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
            this.Exp = Exp;
        }
        public override void Info()
        {
            Console.WriteLine($"Имя: {Name};\nВозраст: {Age};\nEmail: {Email};\nНомер телефона: {Number};\n" +
                $"Категория программиста: {ProgreammerTypes};\nСтаж работы: {Exp}");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return ($"Категория программиста: {ProgreammerTypes};\nСтаж работы: {Exp}");
            Console.ForegroundColor = ConsoleColor.Gray;
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
