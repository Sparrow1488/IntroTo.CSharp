using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Юра", "Владыка");
            Person p1 = new Person("Андрей", "Геркулесович");
            //задаем свойства объектам класса
            p.SetName("Юра");
            p.SecondName = "Владыка";
            p1.Name = "Андрей";
            p1.SecondName = "Геркулесович";
            Console.WriteLine(p.FullName);
            Console.WriteLine(p1.FullName);

            Console.ReadKey();
        }
    }
}
