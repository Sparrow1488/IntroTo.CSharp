using System;

namespace Anonymous_typers
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new
            {
                Name = "Magic-eat",
                Price = 1000
            };
            Console.WriteLine("PRODUCT: Name: {0}, Price: {1}", product.Name, product.Price);

            var product2 = new
            {
                Name = "Not-magic-eat",
                Pricee = 200
            };
        }
    }
}
