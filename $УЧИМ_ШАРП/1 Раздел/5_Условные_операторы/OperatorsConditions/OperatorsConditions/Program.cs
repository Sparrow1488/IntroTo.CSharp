using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //условные оператор switch
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    {
                        Console.WriteLine("1");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("2");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("0");
                        break;
                    }
            }

            //условные оператор if else
            string userEnter = Console.ReadLine();

            if (userEnter.Equals("шабат шалом", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Шабат шалом");
            }
            else
            {
                Console.WriteLine("Нацик да?");
            }

            //быстрая проверка
            var str = userEnter == "шабат шалом" ? "1" : "2";

            Console.WriteLine(str);

            Console.ReadKey(true);
        }
    }
}
