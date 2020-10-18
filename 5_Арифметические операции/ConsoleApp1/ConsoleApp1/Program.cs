using System;

namespace ConsoleApp1
{
    class Program
    {
        static
            void Main(string[] args)
        {
            // <<<---БИНАРНЫЕ ОПЕРАЦИИ--->>>

            int a = 2;
            int b = 5;
            double res = (double)a / b;
            Console.WriteLine(res);

            double a1 = 2;
            int b1 = 5;
            double result = a1 / b1;
            Console.WriteLine(result);
            
            //деление с остатком
            Console.WriteLine(12 % 5);

            //1.дз
            int num1;
            int num2;
            Console.Write("num1 = ");
            num1 = Console.ReadLine();
            Console.Write("num2 = ");
            num2 = Console.ReadLine();
            Console.Write("Среднее арифметическое = " + (num1 + num2) / 2);
            
            Console.ReadKey();
        }
    }
}
