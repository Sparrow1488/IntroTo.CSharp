using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Person
    {
        private string _name;
        private string _secondName;

        //СВОЙСТВО (обязательно задаются с get и set!)
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
            }
        }

        //СОКРАЩЕННОЕ СВОЙСТВО
        public string SecondName { get; set; }

        public string FullName
        {
            get
            {
                return $"{SecondName} {Name.Substring(0, 1)}.";
            }
        }

        //МЕТОДЫ
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                _name = name;
            }
        }

        //КОНСТРУКТОР 
        public Person(string name, string secondName)
        {
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(secondName))
            {
                _name = name;
                _secondName = secondName;
                
            }
        }
    }
}
