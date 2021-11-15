using System;

namespace LR_09
{
    public class LegendaryHeros
    {
        public int HitPoints;
        public string Name;
        public string TypeHeros;

        public LegendaryHeros(int HitPoint, string Name)
        {
            this.HitPoints = HitPoint;
            this.Name = Name;
        }

        public void Attack()
        {
            Random DiffHit = new Random();
            int DiffHitValue = DiffHit.Next(0, 150);
            this.HitPoints = this.HitPoints - DiffHitValue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nАтакован объект {this.Name}!\nНанесено урона: {DiffHitValue}.\nТекущее здоровье объекта: {this.HitPoints}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Health()
        {
            Random HealHit = new Random();
            int HealHitValue = HealHit.Next(50, 100);
            this.HitPoints = this.HitPoints + HealHitValue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\nИсцелен объект {this.Name}!\nДобавлено здоровья: {HealHitValue}.\nТекущее здоровье объекта: {this.HitPoints}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    public class Hero : LegendaryHeros
    {
        public Hero(int HitPoint, string Name):base(HitPoint, Name)
        {
            this.TypeHeros = "Герой";
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Создан новый объект:\nИмя: {this.Name}\nТип: {this.TypeHeros}\nУровень здоровья: {this.HitPoints}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    public class Undead : LegendaryHeros
    {
        public Undead(int HitPoint, string Name) : base(HitPoint, Name)
        {
            this.TypeHeros = "Нежить";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Создан новый объект:\nИмя: {this.Name}\nТип: {this.TypeHeros}\nУровень здоровья: {this.HitPoints}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
