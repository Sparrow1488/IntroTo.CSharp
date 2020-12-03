using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var bubble = new BubbleSort<int>();
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                bubble.ItemsList.Add(rnd.Next(0, 10));
            }
            bubble.Sort();
            //foreach (var item in bubble.ItemsList)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
