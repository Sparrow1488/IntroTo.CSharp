using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        //
        //<<<---ПЕРЕГРУЖЕННЫЕ МЕТОДЫ НУЖНА ДЛЯ ОПИСАНИЯ ОДНОГО МЕТОДА, КОТОРЫЙ МОЖЕТ ПРИНИМАТЬ
        //      РАЗНЫЕ ПАРАМЕТРЫ--->>>
        //
        /// <summary>
        /// Возвращает сумму двух натуральных чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Возвращает сумму трех натуральных чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        /// <summary>
        /// Возвращает сумму двух дробных чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            //если нам прилетает 2 параметра, но выполняем один метод, если три - то другой
            Console.WriteLine(Sum(a, b));

            Console.ReadKey(true);
        }
    }
}
