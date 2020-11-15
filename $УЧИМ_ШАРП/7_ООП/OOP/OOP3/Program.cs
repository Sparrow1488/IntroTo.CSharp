using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello {2020} год - ужасный год!");
            var pers1 = new Person("Иванька", "Иванович");
            for (int i = 0; i < 5; i++)
            {
                var pos = pers1.Run();
                Console.WriteLine(pos);
            }
            Console.WriteLine("Вызов рекурсии " + Factorial(3));
        }

        //РЕКУРСИЯ
        /*
         * 01:01:20 - Рекурсия
         * https://www.youtube.com/watch?v=7jlpiU6V008&list=PLIIXgDT0bKw4OmiZ9yGmShKsY0XncViZ8&index=10
         */
        public static int Factorial(int value)
        {
            if (value <= 1)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }
    }
}
