using System;
using System.Threading;

namespace _4.CheMutex
{
    internal class Program
    {
        public static Mutex Mutex = new Mutex();
        public static void Main()
        {
            for (int i = 0; i < 5; i++)
                new Example(i);
        }
    }

    internal class Example
    {
        private int Id { get; set; }
        public Example(int id)
        {
            Id = id;
            new Thread(Foo).Start();
        }

        private void Foo()
        {
            Program.Mutex.WaitOne();

            Console.WriteLine($"[{Id}]Thread started Foo");
            Thread.Sleep(900);
            Console.WriteLine($"[{Id}]Thread finished Foo");
            Console.WriteLine();

            Program.Mutex.ReleaseMutex();
        }
    }
}
