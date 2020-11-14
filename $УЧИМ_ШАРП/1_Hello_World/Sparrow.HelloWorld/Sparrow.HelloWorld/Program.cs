using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparrow.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Изменяет цвет консоли
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Wake up, Neo...");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("The Matrix has you...");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("Follow the white rabbit.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("Knock, knock, Neo...");


            Console.ReadKey();
        }
    }
}
