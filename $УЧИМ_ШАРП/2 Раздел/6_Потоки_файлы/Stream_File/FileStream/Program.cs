using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamProj
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            
            using (FileStream fileStream = new FileStream("testFileStream.txt", FileMode.OpenOrCreate))
            {
                byte[] data = Encoding.UTF8.GetBytes(text);
                fileStream.Seek(0, SeekOrigin.Begin);
                await fileStream.WriteAsync(data, 0, data.Length); //длинну указываем для точного определения переданных байт, если передать меньше или больше, то будет ошибка
                Console.WriteLine("Данные успешно записаны!");
            }

            using (FileStream fileStream = File.OpenRead("testFileStream.txt"))
            {
                byte[] buffer = new byte[fileStream.Length]; // получаем данные
                await fileStream.ReadAsync(buffer, 0, Byte.Parse("5")); // читаем первые 5 символов потока байтов (либо все: buffer.Lenght)
                string getData = Encoding.UTF8.GetString(buffer);
                Console.WriteLine($"Полученные данные из файла: {getData}");
            }
            Console.WriteLine("\nЧтение окончено");
        }
    }
}
