using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VisualRenamer
{
    public class Rename
    {
        public static void FileInfo(FileInfo file, TextBox nameFile, TextBox extensFile, TextBox pathFile, TextBox createDateFile)
        {
            nameFile.Text = file.Name;
            extensFile.Text = file.Extension;
            pathFile.Text = file.FullName;
            createDateFile.Text = file.CreationTime.ToString();
            Data.activeFileInfo = file;
        }
        public static void RenameComplete(FileInfo file)
        {
            var rndID = new Random();
            var fullRename = Path.Combine(Data.findPath, Data.mainName);
            string addDateCreate = file.CreationTime.ToString().Replace(".", "").Replace(":", "").Replace(" ", "");
            Data.resultName = $"{Data.mainName} [{addDateCreate}]{file.Extension}";
            try
            {
                if (!file.FullName.Equals(Data.resultName))
                    File.Move(file.FullName, fullRename + Data.resultName);
            }
            catch (IOException) { }
            
        }
    }
}
