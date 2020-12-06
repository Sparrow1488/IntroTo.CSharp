using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выберите промежуток от:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Выберите промежуток до:");
            int num2 = int.Parse(Console.ReadLine());

            uint div2 = 0;
            uint noDiv2 = 0;
            int questNum = num1;

            while (questNum <= num2)
            {
                
                if (questNum % 2 == 0)
                {
                    Console.WriteLine(questNum + " четное");
                    div2++;
                }
                else
                {
                    Console.WriteLine(questNum + " нечетное");
                    noDiv2++; 
                }
                questNum++;
            }

            Console.WriteLine("Кол-во символов перебрано: " + (num2 - num1));
            Console.WriteLine("Кол-во четных из них: " + div2);
            Console.WriteLine("Кол-во нечетных из них: " + noDiv2);

            Console.ReadKey(true);
        }
    }
}
