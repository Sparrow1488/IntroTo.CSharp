using System;
using System.Globalization;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //<<<---ИНТЕРПОЛЯЦИЯ--->>>

            string name = "Tomas";
            short age = 22;
            float height = 1.7f;
            //  <-первый способ->
            Console.WriteLine("<-первый способ->");
            Console.WriteLine($"Name: {name}, age: {age}, height: {height}");
            Console.WriteLine();
            //  <-второй способ->
            Console.WriteLine("<-второй способ->");
            Console.WriteLine("name: {0}, age: {1}, height: {2}м", name, age, height);
            Console.WriteLine();

            string nameUser;
            string ageUser;
            string heightUser;
            bool a = false;

            Console.Write("Введите ваше имя: ");
            nameUser = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            ageUser = Console.ReadLine();
            Console.Write("Введите ваш рост через запятую: ");
            heightUser = Console.ReadLine();

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            float convertHeight = Convert.ToSingle(heightUser, numberFormatInfo);
            
            if (convertHeight > 2)
            {
                Console.WriteLine("--->Ого, громила");
                a = true;
            }
            else
            {
                Console.WriteLine("--->Хилячек");
                a = true;
            }

            //convertHeight = convertHeight + 1;      




            Console.WriteLine("Имя: {0}, age: {1}, height: {2}м", nameUser, ageUser, b);
            Console.ReadKey();
        }
    }
}
