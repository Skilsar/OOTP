using System;
using System.Runtime.Serialization;


namespace LR_14
{
    [Serializable]
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        { }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }

        public Person(string name, int year)
        {
            Name = name;
            Age = year;
        }
    }
}
