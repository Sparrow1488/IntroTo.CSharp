using System;

namespace CatchExeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, res = 0;
            while (true)
            {
                try //определяет в коде тип(формат) ошибки
                {
                    num = int.Parse(Console.ReadLine());
                    res = 1000 / num;
                    Console.WriteLine(res);
                    break;
                }
                //в зависимости от типа(формата) кидает нам нуобходимое исключение
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("нельзя делить на 0");
                }
                //код, даже после обработки ошибки, выполняется все-равно
                finally
                {
                    Console.WriteLine("*/finally code/*");
                }
            }
            Console.WriteLine("Ура, код без исключений!" + res);

        }
    }
}
