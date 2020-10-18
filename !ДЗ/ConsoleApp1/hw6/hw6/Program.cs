using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 430, 6, 34, 22, 23, 664, 453, 23, 124, 656, 45, 432 };
            int[] noEvenArr = new int[arr.Length];
            int evenSum = 0;
            int noEvenSum = 0;
            int minValue = arr[0];


            //<<<---СУММА ЧЕТНЫХ--->>>
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    Console.WriteLine($"{arr[i]} четное, {arr[i]}(массив) + {evenSum}(сумма)");
                    evenSum += arr[i];
                }
                else
                {
                    noEvenArr[i] = arr[i];
                    //Console.WriteLine(arr[i] + " не четное");
                }
            }


            //<<<---СУММА НЕЧЕТНЫХ--->>>
            for (int i = 0; i < noEvenArr.Length; i++)
            {
                if (noEvenArr[i] != 0)
                {
                    Console.WriteLine("нечетное: " + noEvenArr[i]);
                    noEvenSum += noEvenArr[i];
                }
            }


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }
            Console.WriteLine("Сумма четных:\t " + evenSum);
            Console.WriteLine("Сумма нечетных:\t " + noEvenSum);
            Console.WriteLine("Минимальный элемент в массиве arr:\t " + minValue);

            Console.ReadKey();
        }
    }
}
