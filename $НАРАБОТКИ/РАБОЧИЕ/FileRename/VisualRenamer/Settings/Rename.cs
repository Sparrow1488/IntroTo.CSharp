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
        public static void FileInfoImage(MyFile file, TextBox nameFileTB, TextBox extensFilTeTB, TextBox fullNameTB, TextBox createDateFileTB, Panel d)
        {
            nameFileTB.Text = file?.name;
            extensFilTeTB.Text = file?.extension;
            fullNameTB.Text = file?.fullName;
            createDateFileTB.Text = file?.creationDate.ToString();
            if (file.extension.Equals(".png") || file.extension.Equals(".jpg"))
            {
                d.Visible = true;
                d.BackgroundImage = new Bitmap(file?.fullName);
            }
        }
        public static void RenameComplete(MyFile file)
        {
            var fullRename = Path.Combine(file.parentDir, file.newName);
            string dateCreate = file.creationDate.ToString().Replace(".", "").Replace(":", "").Replace(" ", "");
            var resultName = $"{fullRename} - [{dateCreate}]{file.extension}";
            try
            {
                if (!file.fullName.Equals(resultName))
                    File.Move(file.fullName, resultName);
            }
            catch (IOException) { }
        }
        public static void FastRename(TextBox findByExtension)
        {
            foreach (var file in MyFile.receivedFiles)
            {
                if (file.extension.Equals(MyFile.findExtension) || findByExtension.Text.Equals("".Trim()))
                    RenameComplete(file);
            }
        }
    }
}
