using System;

namespace Builder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var builder = new SamsungPhoneBuilder();
            var director = new Director(builder);
            director.Construct();
            var samsung = builder.GetResult();
            Console.WriteLine("{0} готов!", samsung);
        }
    }
}
