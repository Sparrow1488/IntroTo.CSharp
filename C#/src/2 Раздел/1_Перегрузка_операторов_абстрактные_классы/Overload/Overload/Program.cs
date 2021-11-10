using System;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple1 = new Apple("Зеленое яблоко", 100, 100);
            Apple apple2 = new Apple("Красное яблоко", 150, 120);

            var apple = Apple.Add(apple1, apple2);

            var apple3 = apple + apple1;

            Console.WriteLine(apple1);
            Console.WriteLine(apple2);
            Console.WriteLine(apple);
            Console.WriteLine(apple3);
            
        }
    }
}
