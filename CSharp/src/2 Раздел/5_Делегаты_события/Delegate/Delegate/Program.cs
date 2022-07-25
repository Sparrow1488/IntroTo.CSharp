using System;

namespace Delegate
{
    //можем объявлять делегаты и за пределами класса
    /*модификатор доступа*/ /*ключевое слово: delegate*/ /*тип возвращ. значения*/ /*имя*/  /*(тип имя аргумента)*/
    public delegate void MyDelegate();
    public delegate int GetStrLenght(string str);
    class Program
    {
        public delegate int MyValueDelegate(int i);
        //public delegate void Action() == Action   -   синтаксический сахар.

        //public delegate bool Predicate<T>(T value); = Predicate   -   еще один тип делегата, как и Action.
        //возвращает bool значение
        static void Main(string[] args)
        {
            #region delegate
            // ПЕРВЫЙ СПОСОБ СОЗДАНИЯ И ВЫЗОВА ДЕЛЕГАТА
            MyDelegate myDelegate = Method1;
            myDelegate(); //Met1
            myDelegate += Method3; // добавили еще один метод в коллекцию методов делегата
            myDelegate();

            Console.WriteLine();

            // ВТОРОЙ СПОСОБ СОЗДАНИЯ И ВЫЗОВА ДЕЛЕГАТА
            MyDelegate myDelegate2 = new MyDelegate(Method2); // создаем и сразу довабляем через конструктор
            myDelegate2 += Method1;
            myDelegate2 -= Method2; // удаляем второй метод из коллекции
            myDelegate2.Invoke(); // второй способ вызова

            Console.WriteLine();

            // МЫ МОЖЕМ СОЗДАВАТЬ ДЕЛЕГАТ, ИЗ СУЩЕСТВУЮЩИХ ДЕЛЕГАТОВ
            MyDelegate myDelegate3 = myDelegate + myDelegate2;
            myDelegate3.Invoke();

            Console.WriteLine();

            var valueDelegate = new MyValueDelegate(ValueMethod);
            valueDelegate += ValueMethod; 
            valueDelegate += ValueMethod; // вызовется n раз, но вернет только значение последнего метода
            valueDelegate((new Random()).Next(10, 1000));

            Console.WriteLine();

            Action action = Method1;
            //Action<int> actionValue = ValueMethod; - метод должен быть void

            Console.WriteLine();

            Predicate<int> predicate; //принимает ровно один аргумент

            Console.WriteLine();

            Func<int, int> func = ValueMethod; //возвращает последний указанный тип. Можете принимать от 0 до 16 аргументов.
            func?.Invoke(20); //прежде чем вызывать делегат, необходимо удостовериться, что он не пустой.

            GetStrLenght getStrLenght = StrLenghtMethod;
            Console.WriteLine($"Длинна строки: {getStrLenght("моя строка")}"); 
            #endregion
        }
        public static int ValueMethod(int i)
        {
            Console.WriteLine(i);
            return i;
        }
        public static void Method1()
        {
            Console.WriteLine("Метод 1");
        }
        public static void Method2()
        {
            Console.WriteLine("Метод 2");
        }
        public static void Method3()
        {
            Console.WriteLine("Метод 3");
        }
        public static void Method4()
        {
            Console.WriteLine("Метод 4");
        }
        public static int StrLenghtMethod(string str)
        {
            return str.Length;
        }

    }
}
