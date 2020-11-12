using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    class StateProduction
    {
        public static int personalAll = 0;
        public static int allWorkHours = 0;

        public static int personalMine = 0;
        public static int workHoursMinerAll = 0; //рабочие часы всех шахтовиков

        public static int personalPlant = 0;
        public static int workHoursPlanterAll = 0; //рабочие часы всех заводчан
        


        protected static int quantityMines = 1;
        protected static int quantityPlants = 1;

        public static decimal money = 400000M;



        public static void showInfoBuisnes()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Баланс: " + money);
            Console.WriteLine("Весь персонал: " + personalAll);
            Console.WriteLine("Шахт всего: " + personalMine);
            Console.WriteLine("Заводов всего: " + personalPlant);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
