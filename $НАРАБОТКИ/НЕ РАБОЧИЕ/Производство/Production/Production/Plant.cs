using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    class Plant : StateProduction
    {
        //уголя на заводе
        protected static int storageCoal = 0;
        //железа на заводе
        protected static int storageIron = 0;
        //меди на заводе
        protected static int storageCopper = 0;

        protected static int workHoursPlant = 0; //рабочие часы завода

        public static void showInfoPlant()
        {
            Console.WriteLine(">Заводов: " + quantityPlants);
            Console.WriteLine(">Персонала на заводах: " + personalPlant);

            Console.WriteLine(">Угля на складе: " + storageCoal);
            Console.WriteLine(">Железа: " + storageIron);
            Console.WriteLine(">Меди: " + storageCopper);
        }
        
        public static void startWorkPlant()
        {

        }
    }
}
