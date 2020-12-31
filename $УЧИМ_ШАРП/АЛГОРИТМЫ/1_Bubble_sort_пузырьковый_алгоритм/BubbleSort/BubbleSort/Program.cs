using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>()
            {
                243,
                234
            };

            int temp = 0;

            for (int write = 0; write < arr.Count; write++)
            {
                for (int sort = 0; sort < arr.Count - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Count; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();
        }
    }
}
