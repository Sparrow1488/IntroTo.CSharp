using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            //дз3. Проверка на четность
            try
            {
                Console.Write("Число для проврки: ");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Четное");
                }
                else
                {
                    Console.WriteLine("Нечетное");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Что-то пошло не по плану =/");
            }
            
            Console.ReadKey();
        }
    }
}
