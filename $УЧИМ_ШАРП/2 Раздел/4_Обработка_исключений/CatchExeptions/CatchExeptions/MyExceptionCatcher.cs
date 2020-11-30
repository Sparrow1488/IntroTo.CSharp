using System;
using System.Collections.Generic;
using System.Text;

namespace CatchExeptions
{
    // СОЗДАЕМ НАШЕ ИСКЛЮЧЕНИЕ ОТ БАЗОВОГО КЛАССА EXCEPTION
    class MyExceptionCatcher : Exception
    {
        public MyExceptionCatcher() : base("Чел ты... поймал мое исключение")
        {
        }
        public MyExceptionCatcher(string ex) : base(ex)
        {
        }
    }
}
