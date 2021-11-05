using System;
using System.IO;

namespace FileRename
{
    class ShowInfo
    {
        public static void ShowCommands()
        {
            
            WriteProp.SetColorAndWrite("fast", ConsoleColor.DarkBlue);
            Console.WriteLine(" - rename all files");
            WriteProp.SetColorAndWrite("sel", ConsoleColor.DarkBlue);
            Console.WriteLine(" - selectively rename (избирательное)");
        }
        public static void FileInfo(FileInfo file)
        {
            WriteProp.SetColorAndWrite("Name: ", ConsoleColor.DarkMagenta);
            Console.WriteLine(file.Name);

            WriteProp.SetColorAndWrite("Extension: ", ConsoleColor.DarkMagenta);
            Console.WriteLine(file.Extension);

            WriteProp.SetColorAndWrite("Full name: ", ConsoleColor.DarkMagenta);
            Console.WriteLine(file.FullName);

            WriteProp.SetColorAndWrite("Date create: ", ConsoleColor.DarkMagenta);
            Console.WriteLine(file.CreationTimeUtc);
        }
        
    }
}
