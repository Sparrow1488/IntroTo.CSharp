using System;
using System.Collections.Generic;
using System.Text;

namespace GenericApp
{
    public class Eating<T>
        //ограничение на типы
        where T: Product // Т должен быть классом, имеющим конструктор без параметров
    {
        public int Volume { get; private set; }

        public void Add(T product)
        {
            Volume += product.Volume * product.Energy;
        }
    }
}
