using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2дз. Ввести 3 числа и вывести их сумму и произведение
            try
            {
                string test1;
                string test2;
                string test3;
                Console.Write("Введите test1: ");
                test1 = Console.ReadLine();
                double conT1 = double.Parse(test1);

                Console.Write("Введите test2: ");
                test2 = Console.ReadLine();
                double conT2 = double.Parse(test2);

                Console.Write("Введите test3: ");
                test3 = Console.ReadLine();
                double conT3 = double.Parse(test3);

                Console.WriteLine("Выберите что произвести с переменными:\n1.Сложить\n2.Умножить");
                string chose = Console.ReadLine();
                switch (chose)
                {
                    case "1":
                        Console.WriteLine(conT1 + conT2 + conT3);
                        break;
                    case "2":
                        Console.WriteLine(conT1 * conT2 * conT3);
                        break;
                    default:
                        Console.WriteLine("шо");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Произошла ошибка");
            }

            Console.ReadKey();
        }
    }
}
