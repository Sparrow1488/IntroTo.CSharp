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
            //<<<---ПРИМЕР 1--->>>
            Console.Write("Введите код: ");

            bool answer = false;
            string answerOperand = "1234";
            string voidOperand = Console.ReadLine();
            //if (voidOperand == answerOperand)
            //{
            //    answer = true;
            //    Console.WriteLine(answer);
            //}
            //else
            //{
            //    Console.WriteLine(answer);
            //}

            //если answer = (voidOperand == answerOperand), то вернуть true иначе false
            answer = voidOperand == answerOperand ? true : false;
            Console.WriteLine(answer);

            //<<<---ПРИМЕР 2--->>>
            Console.Write("Введите любое число: ");
            int a = int.Parse(Console.ReadLine());
            a = (a > 0) ? a : 0;
            Console.WriteLine(a);
            

            Console.ReadKey();
        }
    }
}
