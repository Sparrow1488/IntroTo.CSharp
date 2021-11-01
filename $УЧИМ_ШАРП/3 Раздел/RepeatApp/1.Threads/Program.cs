using System;
using System.Threading;

namespace _1.Threads
{
    public class Program
    {
        private static Thread _first;
        private static Thread _second;
        public static void Main(string[] args)
        {
            _first = new Thread(Foo2);
            _first.Name = "FIRST";
            _first.Start();

            _second = new Thread(Foo);
            _second.Name = "SECOND";
            _second.Start();

            int max = 500;

            Console.ReadKey();
        }
        private static void Foo()
        {
            int max = 25;
            _first.Join();
            for (int i = 0; i < max; i++)
                PrintThreadInfo();
        }

        private static void Foo2()
        {
            Console.WriteLine($"[{Thread.CurrentThread.Name}]Foo. ");
            Console.WriteLine($"[{Thread.CurrentThread.Name}]Foo start Sleep");
            PrintThreadInfo();
            Thread.Sleep(5000);
            Console.WriteLine($"[{Thread.CurrentThread.Name}]Foo was Sleeped");
        }
        private static void PrintThreadInfo()
        {
            Console.WriteLine($"\n[{_first.Name}]{_first.ThreadState}");
            Console.WriteLine($"[{_second.Name}]{_second.ThreadState}");
        }

    }
}
