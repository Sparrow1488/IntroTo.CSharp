using System;
using System.IO;
using System.Text;

namespace Stream_File
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //мы можем поменять кодировку у самой консоли (?зачем. Странный чел)
            //поток для записи. Файл по умолчанию лежит в Debug
            //1.Путь; 2.Будет ли перезаписан файл, либо дописан; 3.Кодировка  -  ОДНА ИЗ ВОЗМОЖНЫХ ПЕРЕГРУЗОК
            using (var sw = new StreamWriter("testFile.txt", true, Encoding.UTF8)) 
            {
                sw.WriteLine("\tHello world!");
                sw.WriteLine("\tHello User!");
            }

            using (var sr = new StreamReader("testFile.txt", Encoding.Default))
            {
                string txt = sr.ReadToEnd(); // метод для получения всего текста в файле, от начала до конца
                Console.WriteLine(txt);
            }
        }
    }
}
