using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace _7_Isolated_storage
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveUserState();
        }
        private static void SaveUserState()
        {
            // получаем
            IsolatedStorageFile fileReference = IsolatedStorageFile.GetMachineStoreForAssembly();
            IsolatedStorageFileStream localWriteStream = new IsolatedStorageFileStream(@"localTestFile.txt", FileMode.Create, fileReference);
            var streamWriter = new StreamWriter(localWriteStream); // (в данном контексте) декорирующий поток, чтобы не нужно было работать с байтовым стримом
            streamWriter.WriteLine("Я требую пиццу.");
            streamWriter.Close();
            localWriteStream.Close();

            IsolatedStorageFileStream localReadStream = new IsolatedStorageFileStream(@"localTestFile.txt", FileMode.Open, fileReference);
            var streamReader = new StreamReader(localReadStream);
            var read = streamReader.ReadLine();
            Console.WriteLine(read);
        }
    }
}
