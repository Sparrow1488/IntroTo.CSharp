using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    class Program
    {
        static void Str(string simbol, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.Write(simbol);
            }
            
        }
        //РЕАЛИЗОВАТЬ МЕТОД IndexOf
        static int FindInsexArr(int [] arr, int indexNum)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == indexNum)
                {
                    return i;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {
            //ВВЕСТИ СИМВОЛ И ВЫВЕСТИ ЕГО ВВЕДЕНОЕ КОЛ-ВО РАЗ
            Console.Write("Символ: ");
            string simbol = Console.ReadLine();
            Console.Write("Кол-во: ");
            int quantity = int.Parse(Console.ReadLine());
            Str(simbol, quantity);


            Console.WriteLine();


            //РЕАЛИЗОВАТЬ МЕТОД IndexOf
            int[] arr = { 1, 2, 3, 4, 24, 13, 1 };
            //Console.WriteLine("Index: " + Array.IndexOf(arr, 2));
            Console.Write("Индекс какого числа ищем? - ");
            int num = int.Parse(Console.ReadLine());
            int index = FindInsexArr(arr, num);
            Console.WriteLine(index);

            Console.ReadKey();
        }
    }
}
