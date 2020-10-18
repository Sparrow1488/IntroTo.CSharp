using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //  <<<---CONVERT--->>>
            //

            Console.WriteLine("<<<---CONVERT--->>>");
            string str = "20";
            int a = Convert.ToInt32(str);
            Console.WriteLine(a + " int");
            string str1 = "128";
            double b = Convert.ToInt16(str1);
            Console.WriteLine(b + " short");
            string str2 = "22,8";
            double c = Convert.ToDouble(str2);
            Console.WriteLine(c + " double");
            double aD = Convert.ToDouble(a);
            double bD = Convert.ToDouble(b);
            double res = (a + b + c);
            Console.WriteLine(res + " результат сложения");

            Console.WriteLine("Нажмите, чтобы продолжить...");
            Console.ReadKey(true);

            //
            //  <<<---PARSE--->>>
            //

            string tStr = "10.22";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            double d = double.Parse(tStr, numberFormatInfo);
            Console.WriteLine(d + " double с точкой");

            Console.WriteLine("Нажмите, чтобы продолжить...");
            Console.ReadKey(true);

            //
            //  <<<---TRYPARSE--->>>
            //

            string trStr = "5";
            int nTry;

            bool boolean = int.TryParse(trStr, out nTry);
            //TryParse принимает: (строку расконвертации, число для приема + модификатор OUT)
            //Также TryParse выплевывает true, если получилось конверсировать + само число
            if (boolean)
            {
                Console.WriteLine("Успешно удалось распарсить! Результат = " + nTry);
            }
            else
            {
                Console.WriteLine("Не удалось распарсить!");
            }

            Console.WriteLine("Нажмите, чтобы продолжить...");
            Console.ReadKey(true);

            // <<<---ЧЕРЕЗ TRY CATCH--->>>
            string testA = "60";
            try
            {
                int parseTestA = Convert.ToInt32(testA);
                Console.WriteLine("Успешная конвертация! Получено число: " + parseTestA);
            }
            catch(Exception)
            {
                Console.WriteLine("Не удалось конвертировать!");
            }

            Console.WriteLine("Нажмите, чтобы закончить...");
            Console.ReadKey(true);
        }
    }
}
