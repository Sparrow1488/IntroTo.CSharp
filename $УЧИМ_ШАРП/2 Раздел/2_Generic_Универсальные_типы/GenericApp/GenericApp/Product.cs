using System;
using System.Collections.Generic;
using System.Text;

namespace GenericApp
{
    public class Product
    {
        public string Name { get; private set; }
        public int Volume { get; private set; }
        public int Energy { get; private set; }
        public Product(string name, int volume, int energy)
        {
            // TODO: реализовать проверку входных данных

            Name = name;
            Volume = volume;
            Energy = energy;
        }

    }
}
