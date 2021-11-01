using System;
using System.Threading;

namespace RepeatApp
{
    public class Program
    {
        private static Thread _second;
        private static Thread _current;
        public static void Main(string[] args)
        {
            _current = Thread.CurrentThread;
            _second = new Thread(Foo);
            _second.Start();

            for (int i = 0; i < 10; i++)
            {
                i++;
                Console.WriteLine("Main. ", i);

                if (i == 9)
                    Console.WriteLine("Main Finish. ", i);
            }
        }
        private static void Foo()
        {
            for (int i = 0; i < 10; i++)
            {
                i++;
                Console.WriteLine("Foo. ", i);


                if (i == 9)
                    Console.WriteLine("Foo Finish. ", i);
            }
        }
    }
}
