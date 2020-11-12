using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designations
{
    class Program
    {
        static void Main(string[] args)
        {
            string UpperCamlelCase;//Pascal case //Верхняя верблюжья нотация
            string lowerCamlelCase;//Нижняя верблюжья нотация
            string _snake_case;//Змеиная нотация
            string _FAT_SNANAKE_CASE;//ТОЛСТАЯ Змеиная нотация
            //string kebab-case;//Шашлычная нотация
            string sHungarianCase;//Венгерская нотация - перед назв. ставится тип переменной
                                  /*int iHungarianCase;*/ //Венгерская нотация - перед назв. ставится тип переменной

            //<<<---ПРИВЕДЕНИЕ ПЕРЕМЕННЫХ--->>>
            //Не явное приведение
            byte a = 255;
            int c = a;
            Console.WriteLine(c);

            //Явное приведение
            int h = 256; //if h=255, то g=255; if h=256, то g=0; - идет по кругу
            byte g = (byte)h;
            Console.WriteLine(g);


            //<<<---ПРЕОБРАЗОВАНИЕ ТИПОВ--->>>
            //Явное преобразование
            string strF = "1488";
            string strS = "222222";
            int jojo = int.Parse(strF);
            Console.WriteLine(jojo);

            int jojers = Convert.ToInt32(strS);
            Console.WriteLine(jojers);

            //Не явное преобразование
            string strTh = "This str " + 2;
            Console.WriteLine(strTh);











            //просто bool в string
            bool bl2 = true;
            string sBl = bl2.ToString();

            //TryParse
            string memi = "21223";
            if (int.TryParse(memi, out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Не схавал");
            }
            


            Console.ReadKey();
        }
    }
}
