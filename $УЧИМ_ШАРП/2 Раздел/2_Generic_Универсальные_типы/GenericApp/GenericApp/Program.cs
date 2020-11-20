using System;
using System.Collections.Generic;

namespace GenericApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // для универсальныъ типов автоматически определяется тип, указанный в параметрах
            
            var apple = new Product("Яблоко", 200, 350);
            var cake = new Product("Торт", 230, 600);
            var eating = new Eating<Apple>();
            Console.WriteLine(eating.Volume);

            var list = new List<int>(); // коллекции тоже являются универсальными типами

        }
    }
}
