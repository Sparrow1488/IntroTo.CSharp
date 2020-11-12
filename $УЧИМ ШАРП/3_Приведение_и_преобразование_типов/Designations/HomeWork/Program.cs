using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool outWhile = true;
            while (outWhile)
            {
                Console.Write("Введите значение, которое хотите преобразовать: ");
                string enterStr = Console.ReadLine();

                Console.WriteLine("Во что будем конвертировать?");
                string typeParse = Console.ReadLine();
                switch (typeParse)
                {
                    case "int":
                        {
                            if (int.TryParse(enterStr, out int resultParseInt))
                            {
                                Console.WriteLine(resultParseInt);
                            }
                            else
                            {
                                Console.WriteLine("Не удалось преобразовать!");
                            }
                            break;
                        }
                    case "double":
                        {
                            if (double.TryParse(enterStr, out double resultParseDouble))
                            {
                                Console.WriteLine(resultParseDouble);
                            }
                            else
                            {
                                Console.WriteLine("Не удалось преобразовать!");
                            }
                            break;
                        }
                    case "bool":
                        {
                            if (bool.TryParse(enterStr, out bool resultParseBoolean))
                            {
                                Console.WriteLine(resultParseBoolean);
                            }
                            else
                            {
                                Console.WriteLine("Не удалось преобразовать!");
                            }
                            break;
                        }
                    case "exit":
                        {
                            Console.WriteLine("До связи...");
                            outWhile = false;
                            break;
                        }
                    case "clear":
                        {
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введите значение");
                            break;
                        }
                     
                }
            }

            Console.WriteLine("Нажмите, чтобы выйти...");
            Console.ReadKey(true);
        }
    }
}
