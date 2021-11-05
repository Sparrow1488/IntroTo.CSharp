using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLesson
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            var collection = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                var rndPrice = rnd.Next(1000, 1003);
                var product = new Product("Product_" + i, rndPrice);
                collection.Add(product);
            }

            var res1 = from item in collection
                       where item.Price > 1400
                       orderby item.Price //сортирует по стоимости от мин. к большему
                       select item;
            foreach (var num in res1)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            var res2 = collection.Where(item => item.Price > 1400 && item.Price < 1840);
            foreach (var num in res2)
            {
                Console.WriteLine(num);
            }

            //преобразуем коллекцию в другой тип
            Console.WriteLine("выводим только цены");
            var selectProducts = collection.Select(prod => prod.Price);
            foreach (var prod in selectProducts)
            {
                Console.WriteLine("Цены: " + prod);
            }

            //сортируем по цене
            Console.WriteLine("сортируем по цене");
            var orderByPrice = collection.OrderBy(prod => prod.Price)
                                         .ThenByDescending(item => item.Name);
            foreach (var product in orderByPrice)
            {
                Console.WriteLine(product);
            }

            //группируем
            Console.WriteLine("сгруппируем");
            var groupbyPrice = collection.GroupBy(group => group.Price);
            foreach (var group in groupbyPrice)
            {
                Console.WriteLine("Ключ: " + group.Key); //цена
                foreach (var product in group)
                {
                    Console.WriteLine($"\t{product}"); //продукт, у которого одинаковая цена
                }
                Console.WriteLine();
                //сгруппировали несколько коллекцию, 
                //в которой цена у продуктов повторяется
            }
            var all = collection.All(item => item.Price == 1000);
            Console.WriteLine("Все продукты имеют такую цену?: " + all);
            var any = collection.Any(item => item.Price == 1000);
            Console.WriteLine("Хотя бы один продукт имеет такую цену?: " + any);
            var contains = collection.Contains(collection[2]);
            Console.WriteLine("Коллекция содержит этот элемент: " + contains); // можем так же на проверку вставить любой объект
        }
    }
}
