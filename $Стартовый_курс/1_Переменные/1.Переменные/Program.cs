using System;

namespace LessonOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            System.Console.WriteLine("Hello world!"); //обращаемся к пространству имен, если не подключена библиотека
            bool a = true;      //true / false
            Console.WriteLine(a);
            sbyte b = 127;      // -128...127
            Console.WriteLine(b);
            int a1 = 1;         // -много...+много
            Console.WriteLine(a1);
            float b1 = 5.4f;    // -много дробных...+много дробных
            Console.WriteLine(b1);
            short c1 = 32750;   // -32768...+32767
            Console.WriteLine(c1);
            // и другие переменные

            int a2, b2, c2;
            a2 = 3;
            b2 = 5;
            c2 = 10;
            Console.WriteLine(a2 + " " + b2 + " " + c2);

            Console.ReadLine();
        }
    }
}
