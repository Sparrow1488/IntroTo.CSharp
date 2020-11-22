using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MyDelegate
{
    public class MyClass
    {
        delegate void Hello();
        Hello helloW;
        Hello getTime;
        public static Dictionary<string, Delegate> dCollection = new Dictionary<string, Delegate>()
        {
            { "hello", new MyClass().helloW},
            { "get", new MyClass().getTime}
        };
        
        
        public void AddAllDelegate()
        {
            helloW = HelloWorld;
            getTime = GetTime;
        }
        public static void GetAll(string c)
        {
            foreach (KeyValuePair<string, Delegate> item in dCollection)
            {
                if (c == item.Key)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }

        public void HelloWorld()
        {
            Console.WriteLine("HelloWorld");
        }
        public void GetTime()
        {
            Console.WriteLine("21.11.2020");
        }
    }
}
