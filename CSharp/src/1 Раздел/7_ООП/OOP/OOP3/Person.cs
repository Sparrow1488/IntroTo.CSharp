using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class Person
    {
        //private string _name;
        //private string _secondName;
        public Person(string secondName, string name)
        {
            Name = name;
            SecondName = secondName;
        }

        public string FullName
        {
            get 
            {
                return $"{Name} {SecondName}";
            } 
        }
        public string Name { get; private set;}
        public string SecondName { get; private set;}

        public int X { get; private set; }
        public int Y { get; private set; }

        //ПЕРЕГРУЗКИ МЕТОДОВ
        public string Run()
        {
            var rnd = new Random();
            X = rnd.Next(-2, 2);
            Y = rnd.Next(-2, 2);

            return $"{Name} ({X}, {Y})";
        }

        public string Run(int x, int y)
        {
            X = x;
            Y = y;
            return $"{Name} ({X}, {Y})";
        }
    }
}
