using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumeration
{
    class Program
    {
        //перечисления
        enum Days
        {
            Mon = 1,
            Thu,
            Wed,
            Thr,
            Fri,
            Sat,
            Sun
        }

        static void Main(string[] args)
        {
            //одномерный массив
            int[] arrayInt = new int[3];
            arrayInt[0] = 1;
            arrayInt[1] = 1;
            arrayInt[2] = 1;

            //списки
            List<string> listInt = new List<string>();
            listInt.Add("string0");
            listInt.Add("string1");
            listInt.Add("string2");

            foreach (string it in listInt)
            {
                Console.WriteLine(it);
            }

            Console.ReadKey(true);
        }
    }
}
