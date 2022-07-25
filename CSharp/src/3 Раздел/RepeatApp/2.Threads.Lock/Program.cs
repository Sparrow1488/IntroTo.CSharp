using System;
using System.Threading;

namespace _2.Threads.Lock
{
    public class Program
    {
        private static int _value = 0;
        private static readonly object _lock = new object();
        public static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                var t = new Thread(Count);
                t.Name = "Thread-" + i;
                t.Start();
            }
        }
        private static void Count()
        {
            lock (_lock)
            {
                for (; _value < 10; _value++)
                    Console.WriteLine(Thread.CurrentThread.Name + "  " + _value);
                _value = 0;
                Console.WriteLine("\n");
            }
        }
    }
}
