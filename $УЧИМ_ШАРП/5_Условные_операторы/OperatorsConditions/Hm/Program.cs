using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hm
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int inputOneNum = int.Parse(Console.ReadLine());
            max = max < inputOneNum ? inputOneNum : max;
            int inputTwoNum = int.Parse(Console.ReadLine());
            max = max < inputTwoNum ? inputTwoNum : max;
            int inputThreeNum = int.Parse(Console.ReadLine());
            max = max < inputThreeNum ? inputThreeNum : max;
            Console.WriteLine("Max: " + max);

            if(max % 2 == 0)
            {
                Console.WriteLine(max + " четное");
            }
            else
            {
                Console.WriteLine(max + " не четное");
            }
            var smallOnehungred = max < 100 ? "меньше ста" : "больше ста";
            Console.WriteLine(smallOnehungred);
            Console.ReadKey(true);
        }
    }
}
