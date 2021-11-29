using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace LR_10
{
    public class Game<T> : IEnumerable<T> where T : Player
    {
        public BlockingCollection<T> players = new BlockingCollection<T>();
        public Dictionary<int, T> dict = new Dictionary<int, T>();
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator<T> GetEnumerator()
        {
            foreach (T foo in this.players)
            {
                yield return foo;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)players).GetEnumerator();
        }

        public void Show()//вывод
        {
            foreach (var item in players)
            {
                Console.WriteLine(item);
            }
        }
        public void ShowDict()//вывод ключ + значение
        {
            foreach (KeyValuePair<int, T> element in dict)
                Console.WriteLine("Ключ: {0}\t\tЗначение: {1}", element.Key, element.Value);
        }
        public void Remove(int numb)//удаление
        {
            for (int i = 0; numb > 0; i++)
            {
                if (dict.ContainsKey(i))
                {
                    dict.Remove(i);
                    numb--;
                }
            }
        }
    }
    public class Player
    {
        public string Name;

        public Player(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
