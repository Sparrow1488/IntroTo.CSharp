using System;
using GenericMethods.Classes;

namespace GenericMethods
{
    class Program
    {
        static int GetRndLenght()
        {
            var rnd = new Random();
            return rnd.Next(1,1000);
        }
        static int GetSrtLenght(string str)
        {
            return str.Length;
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.GetTypeMethod("шо"));
            Console.WriteLine(myClass.GetTypeMethod(new Exception()));

            MyDelegate<string, int> mD1 = new MyDelegate<string, int>(GetSrtLenght);
            Console.WriteLine(mD1("Это мой делегат"));

            MyDelegate<int> mD2 = new MyDelegate<int>(GetRndLenght);
            Console.WriteLine(mD2());

        }
    }
}
