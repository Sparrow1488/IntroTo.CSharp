using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle
{
    class Program
    {
        static void Main(string[] args)
        {

            //ЦИКЛ FOR
            Random rnd = new Random();
            var list = new List<int>();
            
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(1,10));
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("Элементов в list = " + list.Count);

            Console.WriteLine(list.Sum() + " сумма всех чисел");

            //ЦИКЛ WHILE
            decimal maxVolumeWater = 32.2M;
            decimal nowVolumewater = 22.1M;
            while(nowVolumewater < maxVolumeWater)
            {
                nowVolumewater += 0.1M;
                Console.WriteLine(nowVolumewater);
            }

            sbyte counter = 0;
            Console.WriteLine("Просто вывожу значения list через while:");
            while(counter < list.Count)
            {
                Console.WriteLine(list[counter]);
                counter++;
            }

            //ЦИКЛ DO WHILE

            do
            {
                Console.WriteLine("Да, counter = " + counter + " и я действительно выполню это, не смотря на условие (но только один раз!)");
            } while (counter < 0);


            //ЦИКЛ FOREACH
            Console.WriteLine("Вывожу list через foreach");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //ВЛОЖЕННЫЕ ЦИКЛЫ
            int width = 5;
            int height = 5;
            int[,] rndNums = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    rndNums[i,j] = rnd.Next(1,100);
                    Console.Write(rndNums[i,j] + "\t");
                }
                Console.WriteLine();
            }


            Console.ReadKey(true);
        }
    }
}
