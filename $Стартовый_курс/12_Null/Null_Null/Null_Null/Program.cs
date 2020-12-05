using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Null
{
    // hello world!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    class Program
    {
        static int[] GetArray()
        {
            int[] array = null;

            return array;
        }

        static void Main(string[] args)
        {
            int a; //значимые типы не могут быть null, поскольку null - ссылка
            int[] testArr = new int[20]; //бахаем массив
            testArr = null; //очищаем ссылку на данные => удаляем массив

            //NULL ОБЪЕДИНЕНИЯ
            string str = null;
            string result = str ?? string.Empty;
            Console.WriteLine("строка имеет длинну " + result.Length);

            //NULL ПРИСВАИВАНИЯ ОБЪЕДИНЕНИЯ
            //доступно только в C# 8.0
            //string str1 = null;
            //str1 ??= "0";
            //Console.WriteLine(str1);

            //ОПЕРАТОР УСЛОВНОГО NULL 
            int[] setArray = GetArray();
            Console.WriteLine("Сумма массива равна " + (setArray?.Sum() ?? 0));
            //?. - если массив содержит null, то отмэна вызова метода sum()

            Console.ReadKey();
        }
    }
}
