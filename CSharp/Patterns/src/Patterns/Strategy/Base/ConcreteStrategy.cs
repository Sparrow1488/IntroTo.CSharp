using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Base
{
    public class ConcreteStrategy : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Второй алгоритм");
        }
    }
}
