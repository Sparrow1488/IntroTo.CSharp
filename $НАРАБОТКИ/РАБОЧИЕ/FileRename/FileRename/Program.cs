using System;
using System.IO;

namespace FileRename
{
    class Program
    {
        public static string path = null;
        public static string rename = "renameFile";
        public static string extension = null;
        static void Main(string[] args)
        {
            while (true)
                if (WhitePath())
                    break;

            while (true)
                if (WriteExtension())
                    break;

            while (true)
                if (WriteRename())
                    break;

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] fileInfo = dirInfo.GetFiles();

            foreach (var file in fileInfo)
            {
                if (file.Extension.Equals(extension))
                {
                    var rndID = new Random();
                    ShowInfo.FileInfo(file);
                    
                    Rename.ShowRename(file);
                    Console.WriteLine();
                }
            }

            ShowInfo.ShowCommands();
            Console.Write("Write: ");
            var choose = Console.ReadLine();

            if (choose.Equals("fast"))
                Rename.FastRenameComplete(fileInfo);
            if (choose.Equals("sel"))
                Rename.SelectivelyRenameComplete(fileInfo);

            Console.WriteLine("Exit");
        }

        static bool WhitePath()
        {
            Console.Write("Path: ");
            path = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Некорректная ссылка");
            else 
                return true;
        }
        static bool WriteExtension()
        {
            Console.Write("Find for .txt/.png/.mp4 ...: ");
            extension = Console.ReadLine().Trim();
            var chExtension = extension.ToCharArray();
            if (!extension[0].Equals('.'))
                throw new ArgumentException("Некорректный ввод");
            else
                return true;
        }
        static bool WriteRename()
        {
            Console.Write("Your new Files name: ");
            rename = Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(rename))
                throw new ArgumentException("Некорректный ввод");
            else
                return true;
        }
    }
}
