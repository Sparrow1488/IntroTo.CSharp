using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Locker_AsyncAwaitThread2
{
    class Program
    {
        static int x = 0;
        static object locker = new object();
        public static string path = "testThread.txt";
        static bool writeComplete = false;

        static void Main(string[] args)
        {
            #region Metanit locker
            //for (int i = 0; i < 5; i++)
            //{
            //    Thread myThread = new Thread(Count);
            //    myThread.Name = "Поток " + i.ToString();
            //    myThread.Start();
            //}
            #endregion

            #region MyPoopCode
            // Чтобы не произошло кринжа и мы сначала не прочитали пустой файл, а только потом его заполнили
            // мы бахнули локер и метод Sleep, чтобы сначала началась запись, а затем вывод. 
            // TODO: довести систему до ума. Избавиться от данных костылей
            Console.WriteLine("Пошел поток");
            Thread threadWrite = new Thread(WriteThread);
            threadWrite.Priority = ThreadPriority.Highest; //устанавливаем приоритетность выполенения потоков
            Thread threadRead = new Thread(ReadThread);
            threadRead.Priority = ThreadPriority.Lowest;

            threadWrite.Start();
            threadRead.Start();
            Console.ReadLine();
            WaitCompleteThread(threadWrite);
            #endregion
        }
        public static void Count()
        {
            lock (locker) // если убрать локер, будет заметна разница в выполнении
            {
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                    x++;
                    Thread.Sleep(100);
                }
            }
        }
        public static void WriteThread()
        {
            string text = "";
            var rnd = new Random();
            lock (locker)
            {
                Console.WriteLine("Write...");

                for (int i = 0; i < 10; i++)
                {
                    text += rnd.Next(0, 10) + " ";
                    Thread.Sleep(1000);
                }
                using (var sw = new StreamWriter(path, false))
                {
                    sw.WriteLine(text);
                }
            }
        }
        public static void ReadThread()
        {
            lock (locker)
            {
                Console.WriteLine("Read...");

                using (var sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
        }
        public static void WaitCompleteThread(Thread waitThread)
        {
            while (true)
            {
                if (!waitThread.IsAlive)
                {
                    writeComplete = true;
                    Console.WriteLine("Done!");
                    break;
                }
            }
        }
    }
}
