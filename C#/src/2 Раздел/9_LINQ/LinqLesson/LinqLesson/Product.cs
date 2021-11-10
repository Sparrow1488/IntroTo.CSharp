using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLesson
{
    class Product
    {
        public string Name { get; }
        public int Price { get; }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name} - {Price}";
        }
    }
}
