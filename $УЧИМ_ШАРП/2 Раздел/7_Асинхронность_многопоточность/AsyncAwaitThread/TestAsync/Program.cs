using System;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Text;

namespace TestAsync
{
    class Program
    {
        public static object locker = new object();
        static void Main(string[] args)
        {
            string path1 = "testOperation1.txt";

            Console.WriteLine("Start");

            while (true)
            {
                Console.WriteLine("wait...");
                if (WriteFileRndAsync(path1).Result)
                {
                    ReadFile(path1);
                    break;
                }
            }
        }

        static async Task<bool> WriteFileRndAsync(string path)
        {
            string testText = "";
            await Task.Run(() => {
                lock (locker)
                {
                    var rnd = new Random();
                    for (int i = 0; i < 100; i++)
                    {
                        testText += $"{rnd.Next(0, 10)} ";
                        Thread.Sleep(10);
                    }
                }
            });
            using (var sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine(testText);
            }
            return true;
        }
        static void ReadFile(string path)
        {
            Thread.Sleep(100);
            lock (locker)
            {
                using (var sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            
        }
    }
}
