using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 1, 3, 5, 6, 243, 23, 234, 432, 521, 4235, 646, 532 };

            Console.WriteLine("Максимальный элемент " + numArr.Max());
            Console.WriteLine("Минимальный элемент " + numArr.Min());
            Console.WriteLine("Сумма четных элементов " + numArr.Where(i => i % 2 == 0).Sum());
            Console.WriteLine();
            int findNum = int.Parse(Console.ReadLine());
            
        }
    }
}
