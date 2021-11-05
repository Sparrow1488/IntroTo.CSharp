using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseProducts p1 = new BaseProducts();
            BaseProducts.AddProduct(40, "Молоко");
            BaseProducts.AddProduct(100, "Шоколадка");
            BaseProducts.AddProduct(20, "Булка");

            BaseProducts.InfoProducts();
            BaseProducts.GetProduct("Молоко");

            Console.ReadKey(true);
        }
    }
}
        

