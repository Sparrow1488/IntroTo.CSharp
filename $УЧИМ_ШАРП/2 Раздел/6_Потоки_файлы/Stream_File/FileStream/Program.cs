using System;
using System.IO;
using System.Text;


namespace FileStreamProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            
            using (FileStream fileStream = new FileStream("testFileStream.txt", FileMode.OpenOrCreate))
            {
                byte[] data = Encoding.UTF8.GetBytes(text);
                fileStream.Write(data, 0, data.Length);
                Console.WriteLine("Данные успешно записаны!");
            }

            using (FileStream fileStream = File.OpenRead("testFileStream.txt"))
            {
                byte[] buffer = new byte[fileStream.Length]; // получаем данные
                fileStream.Read(buffer, 0, buffer.Length); // читаем
                string getData = Encoding.UTF8.GetString(buffer);
                Console.WriteLine($"Полученные данные из файла: {getData}");
            }
            Console.WriteLine("\nЧтение окончено");
        }
    }
}
