using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new LadaSeven());
            cars.Add(new BMW());
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Move(200)} ч");
            }

            Cyborg cyborg = new Cyborg();
            Console.WriteLine($"{cyborg.Name} проехал за {((ICar)cyborg).Move(1000)}");
            Console.WriteLine($"{cyborg.Name} прошел за {((IPerson)cyborg).Move(1000)}");
        }

    }
}
