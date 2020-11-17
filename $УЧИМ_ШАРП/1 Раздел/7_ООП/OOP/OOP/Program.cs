using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.firstName = "Валентин";
            p1.LastName = "Альбертович";

            Person p2 = new Person();
            p2.firstName = "Пожилой";
            p2.LastName = "Жма";




            var d1 = new Doctor();
            d1.firstName = "Юрий";
            d1.LastName = "Геркулесович";
            d1.clasification = "Самый главный, блин, доктор!11!1";

            Console.WriteLine("доктор имя " + d1.firstName);
            Console.WriteLine("доктор фамилия " + d1.LastName);
            Console.WriteLine("доктор специализация " + d1.clasification);
            //от доктора оставляем параметры человека
            //ПОЛИМОРФИЗМ - ОТ НАСЛЕДНИКА К БАЗОВОМУ
            Person personDoctor = d1;
            Console.WriteLine("доктор, как человек имя " + personDoctor.firstName);
            Console.WriteLine("доктор, как человек фамилия " + personDoctor.LastName);

            Console.ReadKey(true);

        }
    }
}
