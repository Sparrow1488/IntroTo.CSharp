using System;
using System.IO;
using System.Runtime.InteropServices;

namespace FileRename
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = null;

            Console.Write("Path: ");
            path = Console.ReadLine();

            #region GetHeightWidth
            //int frameWidth = 0;
            //int frameHeight = 0;
            //byte[] fileDataByte = new byte[8];
            //using (FileStream stream = new FileStream(@"G:\фильмс\sfm\$отдельно sfm\отсторт\BioShock\[Bioshock Infinite] Metssfm,pixie Willow 6952.mp4", FileMode.Open))
            //{
            //    stream.Seek(64, SeekOrigin.Begin);
            //    stream.Read(fileDataByte, 0, 8);
            //    frameWidth = BitConverter.ToInt32(fileDataByte, 63);
            //    frameHeight = BitConverter.ToInt32(fileDataByte, 31);
            //    Console.WriteLine(frameWidth);
            //    Console.WriteLine(frameHeight);
            //}
            //DirectoryInfo dirInfo = new DirectoryInfo(path);
            #endregion
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] fileInfo = dirInfo.GetFiles();
            var testFile = fileInfo[0];
            var rnd = new Random();
            testFile.MoveTo(testFile.Name + $"{ rnd.Next(1000, 9999).ToString()}");

            foreach (var file in fileInfo)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine();
            }
            Console.WriteLine("===");
            //using (var files = new FileInfo)
        }
    }
}
