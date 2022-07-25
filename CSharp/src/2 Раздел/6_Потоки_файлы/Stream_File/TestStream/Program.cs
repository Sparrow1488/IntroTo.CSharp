using System;
using System.IO;
using System.Text;

namespace TestStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test1.txt";
            using (var cw = new StreamWriter(path, true))
            {
                cw.WriteLine($"{DateTime.Now.Hour}:{DateTime.Now.Minute}");
            }
            using (var cr = new StreamReader(path))
            {
                string str = cr.ReadToEnd();
                Console.WriteLine(str);
            }
        }
    }
}
