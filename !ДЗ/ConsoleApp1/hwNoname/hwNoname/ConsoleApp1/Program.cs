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
            Console.Write("Введите высоту: ");
            string height = Console.ReadLine();
            Console.Write("Введите ширину: ");
            string width = Console.ReadLine();
            int h = int.Parse(height);
            int w = int.Parse(width);
            for (int i = 0; i < h; i++)
            {
                Console.Write("▀");
                for (int j = 0; j < w; j++)
                {
                    Console.Write("▀");
                }
                Console.WriteLine();
            }
            if (h == w)
            {
                Console.WriteLine("Это квадрат");
            }
            else
            {
                Console.WriteLine("Это прямоугольник");
            }
            Console.ReadKey();
        }
    }
}
