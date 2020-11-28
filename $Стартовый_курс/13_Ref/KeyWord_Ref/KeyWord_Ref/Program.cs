using System;

namespace KeyWord_Ref
{
    class Program
    {
        //https://www.youtube.com/watch?v=H3gznh97TlQ&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=62
        /*если тип уже является ссылочным, то писать кл.слово ref не нужно (прим.: строки, классы).*/
        static public void Foo(ref int a)
        {
            a = -10;
        } 
        static public void ArrM(ref int[] arr)
        {
            arr[1] = 10;
            arr = null;
        }
        static void Main(string[] args)
        {
            int a = 0;
            Foo(ref a);
            Console.WriteLine(a); //-10

            int[] myArray = { 1,4,8 };
            ArrM(ref myArray);
            Console.WriteLine(myArray[1]);
        }
    }
}
