using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altered
{
    class Program
    {
        static void Main(string[] args)
        {
            //ВСЕ ПЕРЕМЕННЫЕ ХРОНЯТСЯ В СТЕКЕ, КРОМЕ STRING, ТК ОНА МОЖЕТ 
            //БЫТЬ БЕСКОНЕЧНО БОЛЬШОЙ

            double a = 2.1;
            bool tr = a.Equals(2);
            Console.WriteLine(tr);

            decimal d = 2.4M;
            d.ToString();
            Console.WriteLine(d.GetType());
            Console.WriteLine(d.GetHashCode());

            string str = "This is string";
            string empty = "510 12 12 12";
            char simbol = str.First(); //присваивает первый элемент строки str
            Console.WriteLine(simbol + " первый элемент");

            string newE = empty.Replace('2', '9'); //заменяет один символ на другой
            Console.WriteLine(newE);

            string[] arrEmpty = empty.Split(' '); //разделяет строку на элементы массива
                                                  //до по заданному символу
            foreach (var el in arrEmpty)
            {
                Console.Write(el);
            }
            Console.WriteLine();

            var bb = empty.Skip(3); //пропускает указанное чеисло символов
            foreach (var i in bb)
            {
                Console.Write(i);
            }
            

            Console.WriteLine(); 


            Console.ReadKey();
        }
    }
}
