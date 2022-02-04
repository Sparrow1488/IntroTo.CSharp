using System;
using System.IO;
using GarbageCollector = System.GC;

namespace LearnSharp4.GC
{
    internal class Program
    {
        public static void Main()
        {
            var info = new FileInfo("./Program.cs");
            var generation = GarbageCollector.GetGeneration(info);
            Console.WriteLine("Поколение - " + generation);
        }
    }
}
