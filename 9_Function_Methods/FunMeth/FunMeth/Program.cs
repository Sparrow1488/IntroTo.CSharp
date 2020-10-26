using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunMeth
{
    class Program
    {
        //результатом работы будет int
        static double Sum(double value_1, double value_2)
        {
            return value_1 * value_2;
        }
        //результатом работы будет string
        static string PrintStr(string c)
        {
            Console.WriteLine(c);
            return c;
        }
        //пустой метод
        static void VoidMethod(string str)
        {
            Console.WriteLine("----------");
            Console.WriteLine(str);
            Console.WriteLine(str);
            Console.WriteLine(str);
            Console.WriteLine("----------");
        } //в пустой метод не обязательно передавать параметры

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = Sum(a, b);
            Console.WriteLine(c);

            PrintStr("вернул строку строку"); //через метод, возвращающий string
            VoidMethod("str"); //через пустой метод

            Console.ReadKey();
        }
    }
}
