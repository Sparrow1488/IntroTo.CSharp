using System;

namespace MyDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.AddAllDelegate();
            while (true)
            {
                string c = Console.ReadLine();
                MyClass.GetAll(c);
            }
        }
    }
}
