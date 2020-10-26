using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 23, 234, 234, 12, 344, 545, 13};
            int[] arr2 = arr[1..4];

            

            //ПОКАЗАТЬ ПОСЛЕД ЭЛЕМЕНТ МАССИВА
            Console.WriteLine(arr[arr.Length - 1]);
            //Console.WriteLine(arr[^1]);
            Console.ReadKey(true);
        }
    }
}
