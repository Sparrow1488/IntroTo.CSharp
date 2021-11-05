using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    class Shop
    {
        StateProduction stateProduction = new StateProduction();

        protected static int personalInShop = 30;
        protected static int machinePlant = 10;
        protected static int machineMine = 10;
        protected static int plant = 3;
        protected static int mine = 3;

        public static void infoShop()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Работяга на месте: {personalInShop}шт; Цена: 5,000");
            Console.WriteLine($"Станков для завода: {machinePlant}шт; Цена: 20,000");
            Console.WriteLine($"Станков для шахты: {machineMine}шт; Цена: 15,000");
            Console.WriteLine($"Заводов свободно: {plant}шт; Цена: 200,000");
            Console.WriteLine($"Шахт свободно: {mine}шт; Цена: 250,000");
            Console.ForegroundColor = ConsoleColor.White;
        }

        protected static void buyPersonalMine()
        {
            Console.Write("Сколько персонала вам нужно?: ");
            int buyPers = int.Parse(Console.ReadLine());
            if (personalInShop < buyPers || buyPers <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("У нас нет столько персонала!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                int pricePers = buyPers * 5000;
                if (StateProduction.money >= pricePers)
                {
                    StateProduction.personalMine += buyPers;
                    personalInShop -= buyPers;
                    StateProduction.money -= pricePers;
                    Console.WriteLine($"Вы приобрели {buyPers} шахтовиков");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Недостаточно денег!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        protected static void buyPersonalPlant()
        {
            Console.Write("Сколько персонала вам нужно?: ");
            int buyPers = int.Parse(Console.ReadLine());
            if (personalInShop < buyPers || buyPers <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("У нас нет столько персонала!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                int pricePers = buyPers * 5000;
                if (StateProduction.money >= pricePers)
                {
                    StateProduction.personalPlant += buyPers;
                    personalInShop -= buyPers;
                    StateProduction.money -= pricePers;
                    Console.WriteLine($"Вы приобрели {buyPers} заводчан");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Недостаточно денег!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }


        public static void buyPersonalSpecific(string typeWork)
        {
            switch (typeWork)
            {
                case "mine":
                    {
                        Shop.buyPersonalMine();
                        break;
                    }
                case "plant":
                    {
                        Shop.buyPersonalPlant();
                        break;
                    }
            }
            StateProduction.showInfoBuisnes();
        }
    }
}
