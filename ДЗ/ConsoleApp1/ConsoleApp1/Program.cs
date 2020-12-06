using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.дз. Среднее арифметическое двух чисел.
            try
            {
                string num1;
                string num2;
                Console.Write("num1 = ");
                num1 = Console.ReadLine();
                double a = Convert.ToDouble(num1);
                Console.Write("num2 = ");
                num2 = Console.ReadLine();
                double b = Convert.ToDouble(num2);
                Console.WriteLine("Среднее арифметическое = " + (a + b) / 2);
            }
            catch (Exception)
            {
                Console.WriteLine("Введены не верные значения");
            }
        }
    }
}
