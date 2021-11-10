using System;
using System.Threading;

namespace Threads.Monitor_my
{
    internal class Program
    {
        private static object locker = new object();
        private static int _blockIteratorFactor = -1;

        public static void Main()
        {
            Console.WriteLine($"Int32.MaxValue = {Int32.MaxValue}");
            for (int i = 0; i < 5; i++)
            {
                var t = new Thread(() => ElevateInt32((i + 1) * 5));
                t.Name = $"[Thread {i}]";
                t.Start();
            }
        }

        /// <summary>
        /// Поочередное возведение в степень числа с последующим уведомлением параллельных вычислительных потоков о невозможном продолжении вычислений из-за переполнения буфера (используется Int32)
        /// </summary>
        /// <param name="iterations">Кол-во интераций перемножения</param> 
        private static void ElevateInt32(int iterations)
        {
            var threadName = Thread.CurrentThread.Name + " ";
            bool taken = false;
            int res = 1;
            try
            {
                Monitor.Enter(locker, ref taken);

                for (int i = 0; i < iterations; i++)
                {
                    if (_blockIteratorFactor > -1 && _blockIteratorFactor == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(threadName + "Thread warned about impossible calculations. Thread work Stoped");
                        Console.ResetColor();
                        Monitor.Pulse(locker);
                        return;
                    }
                    var factor = i == 0 ? 1 : i;
                    var buffer = res * factor;
                    if (buffer < 0)
                    {
                        Console.WriteLine(threadName + $"Imposible calculate using Int32 (BUFFER = {buffer})");
                        Console.WriteLine(threadName + $"Thread was blocked");
                        _blockIteratorFactor = i;
                        Monitor.Wait(locker);
                        Console.WriteLine(threadName + $"Thread continue calculation after block. Thread work Finished");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(threadName + $"Calculation equals ({buffer} = {res} * {factor})");
                        res = buffer;
                        if (i == 5)
                        {
                            Console.WriteLine(threadName + "Waiting");
                            Monitor.Wait(locker, 500);
                            Console.WriteLine(threadName + "Continue calculate");
                        }
                    }
                }
                Monitor.Pulse(locker);
            }
            finally
            {
                if (taken) Monitor.Exit(locker);
            }
        }

        private static void Foo()
        {
            var token = false;                                      // является результатом блокировки (true - успешно)
            var threadName = Thread.CurrentThread.Name + " ";
            try
            {
                Monitor.Enter(locker, ref token);

                Console.WriteLine(threadName + "Will Sleep");
                Thread.Sleep(200);
                Console.WriteLine(threadName + "Slept");
            }
            finally
            {
                if (token) Monitor.Exit(locker);
            }
        }

    }
}
