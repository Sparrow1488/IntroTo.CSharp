using System;
using System.Collections.Generic;
using System.Text;

namespace Overload
{
    public class Apple : Product
    {
        public Apple(string name, double calorie, double volume) : base(name, calorie, volume)
        {

        }
        //ВСЕ МЕТОДЫ ОБЯЗАТЕЛЬНО ПУБЛИЧНЫЕ И СТАТИЧЕСКИЕ
        public static Apple Add(Apple apple1, Apple apple2)
        {
            var calories = Math.Round(apple1.Calorie + apple2.Calorie / 2.0);
            var volume = Math.Round(apple1.Volume + apple2.Volume / 2.0);
            var apple= new Apple("New Apple", calories, volume);
            return apple;
        }
        public static Apple operator +(Apple apple1, Apple apple2)
        {
            var calories = Math.Round(apple1.Calorie + apple2.Calorie / 2.0);
            var volume = Math.Round(apple1.Volume + apple2.Volume / 2.0);
            var apple = new Apple("Яблоко", calories, volume);
            return apple;
        }
        public static bool operator ==(Apple apple1, Apple apple2)
        {
            return apple1 == apple2;
        }
        public static bool operator !=(Apple apple1, Apple apple2)
        {
            return apple1 != apple2;
        }
    }
}
