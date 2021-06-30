using System;

namespace _10_Explicit_implicit
{
    // <<< = = = Перегрузка_операций_преобразования_типов = = = >>>

    // структура: public static implicit|explicit operator Тип_в_который_надо_преобразовать(исходный_тип param)

    /* Хорошей практикой является определение операторов возвращающих тот тип данных в котором он определен.
       То есть, придерживаться следующего правила - каждому классу обрабатывать только преобразование для себя.
       Другими словами, class Timer реализует, Timer(Counter counter), потому что лучше всего знает, как создать экземпляр самого себя.
    */
    //!!! оператор преобразования имеет четкое ограничение: нельзя указывать преобразование базового класса в производный класс
    class Program
    {
        static void Main(string[] args)
        {
            Person person = "Валентос"; // неявное (implicit)
            person.Age = 18;
            string name = person;
            int age = (int)person; // явное (explicit)
            Console.WriteLine("Name - {0}; age - {1}", name, age);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public static implicit operator string(Person chelik) // неявное приведение типа
        {
            return chelik.Name;
        }
        public static implicit operator Person(string name)
        {
            return new Person(name);
        }
        public static explicit operator int(Person chelik) // явное приведение типа (нужно указать тип)
        {
            return chelik.Age;
        }
        
    }
}
