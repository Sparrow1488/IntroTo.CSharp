using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1Shop
{

    class BaseProducts
    {
        private static Dictionary<int, string> _baseProducts = new Dictionary<int, string>();
        public int a = 1;

        //добавляем продукт
        public static void AddProduct(int price, string name)
        {
            var obgBaseProd = new BaseProducts();
            _baseProducts.Add(price, name);
        }

        //Выводит список продуктов
        public static void InfoProducts()
        {
            BaseProducts baseObj = new BaseProducts();
            foreach (var product in _baseProducts)
            {
                Console.WriteLine(product.Value + " " + product.Key + "Р");
            }
        }
        public static void GetProduct(string name)
        {
            for (int i = 0; i < _baseProducts.Count; i++)
            {
                if (name == _baseProducts.Values[i])
                {
                    Console.WriteLine("нашел");
                }
                else
                {
                    Console.WriteLine("пусто");
                }
            }
            Console.WriteLine(_baseProducts.Count);
        }

        

    }
}
