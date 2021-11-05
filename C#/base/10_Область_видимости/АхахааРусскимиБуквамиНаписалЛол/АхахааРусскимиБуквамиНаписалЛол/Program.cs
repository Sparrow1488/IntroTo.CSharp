using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АхахааРусскимиБуквамиНаписалЛол
{
    class Program
    {
        //https://www.youtube.com/watch?v=FyCp19W_5d8&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=55
        //СТАТИЧЕСКИЕ МЕТОДЫ НЕ МОГУТ РАБОТАТЬ С НЕСТАТИЧЕСКИМИ МЕТОДАМИ
        static int a = 10;
        int b = 5;
        static void Foo()
        {
            int a = 1;
            //b++; - мы не можем использовать, тк static b и b наход. в разных областях видимости
        }
        static void Main(string[] args)
        {

        }
    }
}
