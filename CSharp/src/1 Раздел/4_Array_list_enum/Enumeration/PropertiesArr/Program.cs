using System;

namespace PropertiesArr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CopyTo():");
            string[] arrCopyToMethod = { "12", "123", "123123dsad", "sdffd"};
            string[] arrTakeCopyTo = new string[4];
            arrCopyToMethod.CopyTo(arrTakeCopyTo, 0);
            foreach (var elem in arrTakeCopyTo)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("//////////////////////////");

            Console.WriteLine("Clone():");
            string[] arrCloneMethod = new string[] { "ws", "123", "123123" };
            string[] arrTakeCloneMethod = (string[])arrCloneMethod.Clone();
            foreach (var elem in arrTakeCloneMethod)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("//////////////////////////");

            Console.WriteLine("ConvertAll():");
            string[] arrConvertAll = { "11", "22", "313"};
            int[] arrTakeConvertAll = new int[3];
            arrTakeConvertAll = Array.ConvertAll(arrConvertAll, int.Parse);
            foreach (var elem in arrTakeConvertAll)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("//////////////////////////");

            Console.WriteLine("GetLongLength():");
            string[,] arrGetLongLenght =
            {
                {"12", "123"},
                {"43545", "2345"},
                {"2353", "234"},
                {"678678", "234"}
            };
            //бахнет нам длинну указанного измерения массива
            Console.WriteLine(arrGetLongLenght.GetLongLength(0));
            Console.WriteLine(arrGetLongLenght.GetLongLength(1));
            //Console.WriteLine(arrGetLongLenght.GetLowerBound(1));

            Console.WriteLine("//////////////////////////");

            Console.WriteLine("GetType():");
            Console.WriteLine(arrGetLongLenght.GetType());


            Console.ReadKey();
        }
    }
}
