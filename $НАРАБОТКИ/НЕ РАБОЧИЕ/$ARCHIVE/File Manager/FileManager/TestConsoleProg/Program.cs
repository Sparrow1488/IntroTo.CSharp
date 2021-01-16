using System;
using System.IO;
using System.Linq;

namespace TestConsoleProg
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("Команды:\nopen \nadd\ndelete\nexit");
                
                string chouse = Console.ReadLine();
                switch (chouse)
                {
                    case "open":
                        Console.Write("Введите путь: \t");
                        string url = Console.ReadLine();

                        if (Directory.Exists(url))
                        {
                            DirectoryInfo dir = new DirectoryInfo(url);
                            DirectoryInfo[] dirs = dir.GetDirectories();

                            Console.WriteLine("Директории:");
                            foreach (DirectoryInfo fDir in dirs)
                            {
                                Console.WriteLine("\t" + fDir);
                            }

                            FileInfo[] files = dir.GetFiles();
                            Console.WriteLine("Файлы:");
                            foreach (FileInfo fFile in files)
                            {
                                Console.WriteLine("\t" + fFile);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Директорий не существует");
                        }
                        Console.WriteLine();
                        break;
                    case "add":
                        break;
                    case "delete":
                        break;
                    case "exit":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Вы ввели несуществующее действие");
                        break;
                        
                }
            }

            Console.WriteLine("Нажмите любую клавишу, чтобы выйти");
            Console.ReadKey();
        }
    }
}
