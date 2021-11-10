using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethods.Classes
{
    // делегаты во втором разделе в папке с делегатами :|

    public delegate R MyDelegate<T, R>(T elem); // входное и возращаемое универсальное значение
    public delegate T MyDelegate<T>(); // только возвращаемое значение
    public class MyClass
    {
        public string GetTypeMethod<T>(T elem)
        {
            return elem.GetType().ToString();
        }
    }
}
