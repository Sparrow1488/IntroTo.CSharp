using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello!!!";
            int count = 1;
            foreach (char word in s1)
            {
                Console.Write($"({count}){word} ");
                count++;
            }
            Console.WriteLine();

            Console.WriteLine("Длина строки: " + s1.Length);

            Console.WriteLine(s1.Max());

            Console.WriteLine(s1.Min());

            //ПЕРЕВЕРНУЛ СТРОКУ
            
            char[] ch = s1.ToCharArray();
            //1.1
            var a = s1.ToCharArray().Reverse();
            string str = string.Join("", a);
            Console.WriteLine(str);
            //1.2
            foreach (var item in a)
            {
                Console.Write(item);
            }
            

            Console.ReadKey();
        }
    }
}
