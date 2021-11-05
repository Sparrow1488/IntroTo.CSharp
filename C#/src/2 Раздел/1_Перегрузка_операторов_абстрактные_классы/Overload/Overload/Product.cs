using System;
using System.Collections.Generic;
using System.Text;

namespace Overload
{
    //от абстрактных классов нельзя создавать объекты
    
    //используется для полиморфизма

    //все наследники обяханы использовать наследуемый конструктор
    public abstract class Product
    {
        public string Name { get; private set; }
        public double Calorie { get; private set; }
        public double Volume { get; private set; } //объем

        public Product(string name, double calorie, double volume)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                Name = name;
            }
            if (calorie >= 0)
            {
                Calorie = calorie;
            }
            if (volume > 0)
            {
                Volume = volume;
            }
        }

        public override string ToString()
        {
            return $"{Name}, {Calorie}ккал, {Volume}гр";
        }
    }
}
