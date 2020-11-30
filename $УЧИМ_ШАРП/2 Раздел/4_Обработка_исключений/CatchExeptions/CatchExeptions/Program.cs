using System;

namespace CatchExeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterNum = 0, res = 0;
            while (true)
            {
                try //определяет в коде тип(формат) ошибки
                {
                    enterNum = int.Parse(Console.ReadLine());
                    res = 10 / enterNum;
                    Console.WriteLine(res);
                }
                //в зависимости от типа(формата) кидает нам нуобходимое исключение
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Нельзя делить на ноль"); //чет не робит
                }
                //код, даже после обработки ошибки, выполняется все-равно
                finally
                {
                    Console.WriteLine("*/finally code/*");
                }


                // генерируем наше ичключение
                try
                {
                    throw new MyExceptionCatcher();
                }
                catch(MyExceptionCatcher e)
                {
                    Console.WriteLine(e.Message);
                }


                try
                {
                    /* my code */ы
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Нельзя делить на ноль!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат записи!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    /*  my finally code   */
                }
                break;
            }
            Console.WriteLine("Ура, код без исключений!" + res);

        }
    }
}
