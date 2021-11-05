using System;
using System.Collections.Generic;
using System.Text;

namespace ourShopWardhouseProd.wardhouseDir
{
    public static class WardHouse
    {
        public static Dictionary<int, string> Products { get; private set; } = new Dictionary<int, string>()
        {
            { 12, "Шоколадка" },
            { 32, "Мясо" },
            { 34, "Молоко" },
        };

        public static void GetProducts()
        {
            foreach (var prod in Products.Keys)
            {
                Console.WriteLine($"Продукт: {Products[prod]}, Цена: {prod} рублей");
            }
        }
        
    }
}
