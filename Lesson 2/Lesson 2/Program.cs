using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Lesson - 2");
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " + name);

            string str1 = "27";
            string str2 = "54";

            int a = Convert.ToInt32(str1);
            int b = Convert.ToInt32(str2);

            Console.WriteLine(a + b);


            Console.ReadLine();
        }
    }
}
