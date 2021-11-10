using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitThread
{
    class Program
    {
        public static object locker = new object();
        static void Main(string[] args)
        {
            #region thread
            // Многопоточность создается с помощью отдельного потока
            //Thread thread = new Thread(new ThreadStart(DoWork)); // если наш метод void, то в параметры передаем делегат ThreadStart
            //                                                     // если у метода есть параметры, то в параметр Thread передаем делегат ParameterizedThreadStart (принимает только object)
            //thread.Start();

            //Thread thread2 = new Thread(new ParameterizedThreadStart(iDoWork));
            //thread2.Start(int.MaxValue);

            //int count = 0;
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    count++;
            //    if (count % 100000 == 0) Console.WriteLine("Main");
            //}
            #endregion

            #region async/await
            //DoWorkAsync(10);
            //Console.WriteLine("Main continue");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Main");
            //}
            //Console.WriteLine("Main complete");
            #endregion

            var resultSF = SaveFileAsync("testTXT.txt");
            
            Console.ReadLine();
            Console.WriteLine("Файл заполняется\nwait...");
            Console.WriteLine($"Файл: {resultSF.Result}");
            Console.ReadLine();
        }

        static async Task<bool> SaveFileAsync(string path)
        {
            bool result = await Task.Run(() => SaveFile(path));
            return result;
        }
        static bool SaveFile(string path)
        {
            string text = "";
            // когда мы выполняем код, обернутый в локкер, то ни один другой поток попасть сюда не может (безопасность)
            lock (locker)
            {
                var rnd = new Random();
                for (int i = 0; i < 50000; i++)
                {
                    text += rnd.Next();
                    text += " ";
                }
            }
            
            using (var sw = new StreamWriter(path, false))
            {
                sw.WriteLine(text);
            }

            return true;
        }
        static async Task DoWorkAsync(int count)
        {
            Console.WriteLine("DoWorkAsync start...");
            await Task.Run(() => iDoWork(count));
            Console.WriteLine("DoWorkAsync is complete!");
        }
        static void DoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("DoWork");
            }
        }
        static void iDoWork(object enter)
        {
            for (int i = 0; i < (int)enter; i++)
            {
                Console.WriteLine("DoWork2");
            }
        }
    }
}
