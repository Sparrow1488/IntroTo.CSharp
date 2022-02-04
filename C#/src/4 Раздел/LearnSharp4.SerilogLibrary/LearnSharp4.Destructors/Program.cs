using System;
using System.Threading;

namespace LearnSharp4.Destructors
{
    internal class Program
    {
        public static void Main()
        {
            using (var stream = new MyStream())
            {
                stream.WriteInFile();
                stream.Dispose();
            }
            
        }
    }

    public class MyStream : IDisposable
    {
        private bool _isDisposed;

        ~MyStream()
        {
            Console.WriteLine("Finalize");
            Dispose(false);
        }

        public void WriteInFile()
        {
            Console.WriteLine("Записываем в файл...");
            Thread.Sleep(1000);
            Console.WriteLine("Готово");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
            Dispose(disposing: true);
            GC.SuppressFinalize(this); // подавляем Finalize, тк выполнен Dispose
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Disposing");
                }
                _isDisposed = true;
            }
        }
        
    }
}
