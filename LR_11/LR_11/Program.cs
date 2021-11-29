using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //1
            //Console.WriteLine("Введите количество символов длины месяцев для проверки:");
            //int n = int.Parse(Console.ReadLine());
            //IEnumerable<string> NewMonths = Months.Where(m => m.Length == n);
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Подходящие месяцы");
            //Console.ForegroundColor = ConsoleColor.Gray;
            //foreach (string item in NewMonths)
            //{
            //    Console.WriteLine(item);
            //}
            //2
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nТолько летние и зимние месяцы:");
            Console.ForegroundColor = ConsoleColor.Gray;
            IEnumerable<string> NewMonts2 = from m in Months where m.StartsWith("J") || m.StartsWith("F") || m.StartsWith("Au") || m.StartsWith("D") select m; //вывод месяцев по первым буквам 
            foreach (string item in NewMonts2)
            {
                Console.WriteLine(item);
            }
            //3
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nМесяцы в алфавитном порядке:");
            Console.ForegroundColor = ConsoleColor.Gray;
            IEnumerable<string> NewMonths3 = Months.OrderBy(s => s); //вывод по алфавиту
            foreach (string item in NewMonths3)
            {
                Console.WriteLine(item);
            }
            //4
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nМесяцы с \"u\" и длиной строки не менне 4ех: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            IEnumerable<string> NewMonths4 = Months.Where(n1 => n1.Contains("u") && n1.Length >= 4); //4 и больше буквы
            foreach (string item in NewMonths4)
            {
                Console.WriteLine(item);
            }


            //Часть 2

            List<Book> library = new List<Book>() { new Book("Лесное чудище", "Дима", "Беларусь", 2001, 241, 44, "тонкий", 3),
                                                    new Book("Обитель Анубиса", "Саша", "Германия", 1995, 321, 32, "широкий", 6),
                                                    new Book("Важный человек", "Дима", "США", 1950, 321, 100, "тонкий", 4),
                                                    new Book("Величайший шоумен", "Женя", "Италия", 2010, 321, 28, "широкий", 2),
                                                    new Book("Ведьмы", "Алина", "Норвегия", 1991, 321, 74, "тонкий", 8),
                                                    new Book("RandomBook", "Random", "Random", 2100, 321, 74, "тонкий", 8)
                                                  };
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nВведите автора для поиска:");
            Console.ForegroundColor = ConsoleColor.Gray;
            string findAuthor = Console.ReadLine();
            var lib1 = library.Where(n3 => n3.Author == findAuthor); //поиск по автору 
            foreach (Book item in lib1)
            {
                Console.WriteLine(item.Author + " " + item.Title + " " + item.Year);
            }


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nВведите, после какого года необходим список книг:");
            Console.ForegroundColor = ConsoleColor.Gray;
            int year = int.Parse(Console.ReadLine()); //поиск по году
            var lib2 = library.Where(n3 => n3.Year > year);
            foreach (Book item in lib2)
            {
                Console.WriteLine(item.Author + " " + item.Title + " " + item.Year);
            }


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nCписок книг отсортированных по цене..."); //сортировка по цене 
            Console.ForegroundColor = ConsoleColor.Gray;
            var lib3 = library.OrderBy(n4 => n4.Cost);
            foreach (Book item in lib3)
            {
                Console.WriteLine(item.Author + " " + item.Title + " " + item.Cost);
            }


            var lib4 = library.Min(n5 => n5.BlindingTypeNumber);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nСамая тонкая книга имеет толщину: " + lib4); //толщина книги
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n5 первых самых толстых книг...");
            Console.ForegroundColor = ConsoleColor.Gray;
            var lib5 = library.OrderByDescending(n5 => n5.BlindingTypeNumber).Take(5);
            foreach (Book item in lib5)
            {
                Console.WriteLine(item.Author + " " + item.Title + " " + "толщина: " + item.BlindingTypeNumber);
            }


            List<Team> teams = new List<Team>()
            {
                new Team { Name = "Natus Vincere", Country ="Украина" }, //создание команды
                new Team { Name = "Team Vitality", Country ="Франция" }
            };
            List<Player> players = new List<Player>()
            {
            new Player {Name="s1mple", Team="Natus Vincereз"}, //создание игроков
            new Player {Name="electronic", Team="Natus Vincere"},
            new Player {Name="shox", Team="Team Vitality"}
            };

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nИспользование оператора Join");
            Console.ForegroundColor = ConsoleColor.Gray;
            var result = players.Join(teams, p => p.Team, t => t.Name, (p, t) => new { Name = p.Name, Team = p.Team, Country = t.Country });
            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Team} ({item.Country})");
        }
    }
}
