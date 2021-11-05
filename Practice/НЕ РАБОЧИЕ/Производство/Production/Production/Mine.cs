using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    class Mine : StateProduction
    {
        protected static int coal = 0; //уголь
        protected static int iron = 0; //железо
        protected static int copper = 0; //медь
        protected static int workHoursMine = 0; //рабочие часы шахты

        public static void showInfoMines()
        {
            Console.WriteLine(">Шахт: " + quantityMines);
            Console.WriteLine(">Персонала на шахтах: " + personalMine);

            Console.WriteLine(">Угля: " + coal);
            Console.WriteLine(">Железа: " + iron);
            Console.WriteLine(">Меди: " + copper);
        }
        

        public static void workMine(int workHours)
        {
            if(workHours <= 0 && StateProduction.personalMine < 5)
            {
                Console.WriteLine("Неверное значение или мало людей");
            }
            else
            {
                Console.WriteLine($"Шахта начала работу {workHours} часов");
                Random coalRnd = new Random();
                int miningCoal = coalRnd.Next(1, 7) * personalMine; //добыли угля угля
                Random ironRnd = new Random();
                int miningIron = ironRnd.Next(1, 2) * personalMine; //рандом железа
                Random copperRnd = new Random();
                int miningСopper = copperRnd.Next(1, 5) * personalMine; //рандом меди
                coal += miningCoal;
                iron += miningIron;
                copper += miningСopper;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Добыли угля: {miningCoal}; Стало всего: {coal}");
                Console.WriteLine($"Добыли железа: {miningIron}; Стало всего: {iron}");
                Console.WriteLine($"Добыли меди: {miningСopper}; Стало всего: {copper}");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
}
