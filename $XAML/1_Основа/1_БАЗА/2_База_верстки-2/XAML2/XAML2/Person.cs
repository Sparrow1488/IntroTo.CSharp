using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAML2
{
    public class Person
    {
        public string Name = "Vasya";
        public string SecondName = "Olegovich";
        public int Age = 12;
        public Person(string name, string secName, int age)
        {
            Name = name;
            SecondName = secName;
            Age = age;
        }
        public override string ToString()
        {
            return $"{SecondName} {Name}, {Age} age";
        }
    }
}
