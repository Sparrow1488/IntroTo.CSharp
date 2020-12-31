using System;
using System.Collections.Generic;
using System.IO;

namespace VisualRenamer
{
    public class MyFile
    {
        public string name;
        public string fullName;
        public string parentDir;
        public string extension;
        public string creationDate;
        public string newName = "StandartNewRename";
        public long dateLong;

        public static List<MyFile> receivedFiles = new List<MyFile>();
        public static string findExtension;
        public MyFile(FileInfo file)
        {
            SetParameters(this, file);
            receivedFiles.Add(this);
        }
        public void SetParameters(MyFile myFile, FileInfo fileInfo)
        {
            myFile.name = fileInfo.Name;
            myFile.fullName = fileInfo.FullName;
            myFile.parentDir = fileInfo.DirectoryName;
            myFile.extension = fileInfo.Extension;
            myFile.creationDate = fileInfo.CreationTime.ToString();
        }
        public static void SetNewName(string enterNewName)
        {
            foreach (var file in receivedFiles)
                file.newName = enterNewName;
        }
        
    }
}
