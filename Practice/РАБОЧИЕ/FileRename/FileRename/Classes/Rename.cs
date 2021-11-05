using Microsoft.VisualBasic;
using System;
using System.IO;

namespace FileRename
{
    public class Rename
    {
        public static void RenameComplete(FileInfo file)
        {
            var rndID = new Random();
            var fullNameFile = Path.Combine(Program.path, Program.rename);
            var newName = $"{fullNameFile} - {rndID.Next(1000, 9999)}{Program.extension}";
            FileSystem.Rename(file.FullName, newName);
            var newFile = new FileInfo(newName);
            Console.WriteLine($"Rename <{file.Name}> -> {newFile.Name}");
        }
        public static void FastRenameComplete(FileInfo[] fileInfo)
        {
            foreach (var file in fileInfo)
            {
                if (file.Extension.Equals(Program.extension))
                    RenameComplete(file);
            }
            Console.WriteLine("-   -   -   -");
            Console.WriteLine("Rename complete");
        }
        public static void SelectivelyRenameComplete(FileInfo[] fileInfo)
        {
            foreach (var file in fileInfo)
            {
                if (file.Extension.Equals(Program.extension))
                {
                    ShowRename(file);
                    Console.Write("Применить изменения? (y - да): ");
                    var choose = Console.ReadLine();
                    if (choose.Equals("y"))
                        RenameComplete(file);
                }
            }
            Console.WriteLine("-   -   -   -");
            Console.WriteLine("Rename complete");
        }
        public static void ShowRename(FileInfo file)
        {
            Console.Write("Rename : ");
            WriteProp.SetColorAndWrite(file.Name, ConsoleColor.Yellow);
            Console.Write(" -> ");
            WriteProp.SetColorAndWrite($"'{Program.rename} - (rndID){Program.extension}'", ConsoleColor.Green);
            Console.WriteLine();
        }
    }
}
