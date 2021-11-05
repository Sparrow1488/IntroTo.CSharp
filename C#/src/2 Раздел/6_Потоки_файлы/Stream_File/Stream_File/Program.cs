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
            using (var sw = new StreamWriter("testFile.txt", false, Encoding.UTF8)) 
            {
                sw.WriteLine("giga");
                sw.WriteLine("df");
                sw.WriteLine("gisdfsga");
                sw.WriteLine("Hello User!");
                sw.WriteLine("gdiga");
                sw.WriteLine("gd");
                sw.WriteLine("hi");
                sw.WriteLine("Hello User!");
            }

            Console.WriteLine("$ Читаем файл:");
            using (var sr = new StreamReader("testFile.txt", Encoding.Default))
            {
                string txt = sr.ReadToEnd(); // метод для получения всего текста в файле, от начала до конца
                Console.WriteLine(txt);
            }

            Console.WriteLine("$ Читаем файл, перебирая каждую строку:");
            Console.Write("$ Какую строку искать: ");
            string findTest = Console.ReadLine();
            using (var sr = new StreamReader("testFile.txt", Encoding.Default))
            {
                int counter = 1;
                bool find = false;
                while (!sr.EndOfStream) // перебираем каждую строчку у файла до тех пор, пока они не закончатся
                {
                    string enterFindStr = sr.ReadLine();
                    Console.Write($"   {counter}: '{enterFindStr}'");
                    if (enterFindStr == findTest)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine(" - Find!");

                        Console.ForegroundColor = ConsoleColor.White;
                        find = true;
                        break;
                    }
                    Console.WriteLine();
                    counter++;
                }
                if (!find)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("$ Нет ни одного совпадения!");

                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.WriteLine("$ Способ второй перебора по строчкам: ");
            foreach (string line in File.ReadAllLines("testFile.txt"))
            {
                Console.WriteLine(line);
            }
        }
    }
}