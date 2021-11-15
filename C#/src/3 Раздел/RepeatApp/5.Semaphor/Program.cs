using System;
using System.Threading;

namespace _5.ShoSemaphor
{
    internal class Program
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
                new Queue(i);
        }
    }

    internal class Queue
    {
        public static Semaphore Semaphore = new Semaphore(2, 2);
        public int Id { get; set; }
        public Queue(int id)
        {
            Id = id;
            new Thread(Handle).Start();
        }

        private void Handle()
        {
            Semaphore.WaitOne();

            Console.WriteLine($"[{Id}]Thread: занял очередь");
            Thread.Sleep(900);
            Console.WriteLine($"[{Id}]Thread: освободил очередь");
            Console.WriteLine();

            Semaphore.Release();
        }
    }
}
