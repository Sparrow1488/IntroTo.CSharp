using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Base
{
    public class ConcreteStrategy1 : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Первый алгоритм");
        }
    }
}
