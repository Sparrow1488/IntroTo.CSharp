using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("▀");
            //    }
            //    Console.WriteLine();
            //    for (int c = 10; c <= i; c--)
            //    {
            //        Console.Write("▀");
            //    }
            //}

            for (uint i = 0; i < 10; i++)
            {
                for (uint j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                for (uint c = 10; c <= i; c--)
                {
                    Console.Write("#");
                }
            }
            Console.ReadKey();
        }
    }
}
