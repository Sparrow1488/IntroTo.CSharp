using System;
using System.Collections.Generic;
using System.IO;

namespace VisualRenamer
{
    public class Data
    {
        public static string findPath = null;
        public static string mainName = "BaseRename";
        public static string resultName = "";
        public static string findExtension = null;
        public static FileInfo[] findFiles;
        public static FileInfo activeFileInfo;
        public static List<FileInfo> filesInList = new List<FileInfo>();
    }
}
