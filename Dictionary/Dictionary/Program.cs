using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> _baseProducts = new Dictionary<int, string>();
            _baseProducts.Add(40, "Молоко");
            _baseProducts.Add(100, "Шоколадка");
            _baseProducts.Add(20,"Булка");

            foreach (KeyValuePair<int, string> item in _baseProducts)
            {
                Console.WriteLine($"{item.Key} {item.Value}Р");
            }

            string product = _baseProducts[100];
            Console.WriteLine(product);

            Console.ReadKey(true);
        }
    }
}
