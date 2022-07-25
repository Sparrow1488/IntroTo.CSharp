using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;
            short count = 0;
            while (restart && count < 5)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                
                switch (key)
                {
                    case ConsoleKey.W:
                        Console.WriteLine("Прожата W");
                        ++count;
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("Прожата А");
                        ++count;
                        break;
                    default:
                        Console.WriteLine("Нет заданой клавиши");
                        restart = false;
                        break;
                }
            }
            Console.WriteLine("конец..");
            Console.ReadKey();
        }
    }
}
