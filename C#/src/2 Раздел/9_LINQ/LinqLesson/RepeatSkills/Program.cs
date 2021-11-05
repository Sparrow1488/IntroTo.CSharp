using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepeatSkills
{
    class Program
    {
        private static List<Product> BaseProducts = new List<Product>(){new Product("Apple", 20),
                                                         new Product("Sweet", 1100),
                                                         new Product("Fruct", 900),
                                                         new Product("Pineapple", 90),
                                                         new Product("Fsdf", 490),
                                                         new Product("Pineapple-amega", 9029),
                                                         new Product("Pineapple-alfa", 909),
                                                         new Product("Orbuzzo", 993),
                                                         new Product("Pineapple", 90),
                                                         new Product("Banana", 120)};
        static void Main(string[] args)
        {
            #region Orderby
            Console.WriteLine("///ORDERBY///");
            //var sortProducts = from prod in BaseProducts
            //                   orderby prod.Price descending
            //                   select prod;
            //ShowProductInfo(sortProducts);
            #endregion

            #region FIND (WHERE)
            //Console.WriteLine("///FIND PRODUCT///");
            //var findProducts = from findProd in BaseProducts
            //                   where findProd.Name.Length > 10 && findProd.Price > 10000
            //                   select findProd;
            //ShowProductInfo(findProducts);
            #endregion
            string name = string.Empty;
            int price = 0;
            string[] comps = null;
        }

        private static void ShowProductInfo(IEnumerable<Product> products)
        {
            long timeStart = DateTime.Now.Millisecond;

            if (products != null)
                foreach (var prod in products)
                    Console.WriteLine(prod.Name + ": " + prod.Price);
            else Console.WriteLine("Collection is null");

            Console.WriteLine("Completed in: " + (DateTime.Now.Millisecond - timeStart));
        }
    }

    class Product
    {
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; }
        public int Price { get; }
        public List<string> Components = new List<string>() { "comp1", "comp2", "comp3"};
    }
}
