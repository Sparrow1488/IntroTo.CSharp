using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VisualRenamer
{
    public class Rename
    {
        public static Image BitMap { get; private set; }

        public static void FileInfo(MyFile file, TextBox nameFileTB, TextBox extensFilTeTB, TextBox fullNameTB, TextBox createDateFileTB)
        {
            nameFileTB.Text = file.name;
            extensFilTeTB.Text = file.extension;
            fullNameTB.Text = file.fullName;
            createDateFileTB.Text = file.creationDate.ToString();
        }
        public static bool FileInfoImage(MyFile file, TextBox nameFileTB, TextBox extensFilTeTB, TextBox fullNameTB, TextBox createDateFileTB, Panel picture)
        {
            if (File.Exists(file?.fullName))
            {
                nameFileTB.Text = file?.name;
                extensFilTeTB.Text = file?.extension;
                fullNameTB.Text = file?.fullName;
                createDateFileTB.Text = file?.creationDate.ToString();
                if (file.extension.Equals(".png") || file.extension.Equals(".jpg"))
                {
                    try
                    {
                        picture.Visible = true;
                        picture.BackgroundImage = new Bitmap(file?.fullName);
                        return true;
                    }
                    catch (Exception) { return false; }
                }
            }
            return false;
        }
        public static void RenameComplete(MyFile file)
        {
            var fullRename = Path.Combine(file.parentDir, file.newName);
            string dateCreateNumeral = file.creationDate.ToString().Replace(".", "").Replace(":", "").Replace(" ", "");
            var resultName = $"{fullRename} - [{dateCreateNumeral}]{file.extension}";
            try
            {
                if (!file.fullName.Equals(resultName))
                    File.Move(file.fullName, resultName);
            }
            catch (IOException) { }
        }
        //private static void ApplyRenameModes(MyFile file)
        //{
        //    if(Data.applyModes != null)
        //    {
        //        foreach (var mode in Data.applyModes)
        //        {
        //            if(mode.ToLower().Equals("date"))
        //        }
        //    }
        //}
        public static void FastRename(TextBox findByExtension)
        {
            foreach (var file in MyFile.receivedFiles)
            {
                if (file.extension.Equals(MyFile.findExtension) || findByExtension.Text.Equals("".Trim()))
                    RenameComplete(file);
            }
        }
        public static void UseRenameModes(CheckedListBox modeList)
        {
            foreach (var mode in modeList.CheckedItems)
                Data.applyModes.Add(mode.ToString());
        }
    }
}
