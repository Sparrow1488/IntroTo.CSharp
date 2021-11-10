using System;
using _6_Pattern_Iterator.Pattern;

namespace _6_Pattern_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate myAggregate = new ConcreteAggreagate();
            myAggregate[0] = "Ну";
            myAggregate[1] = "как";
            myAggregate[2] = "там";
            myAggregate[3] = "с";
            myAggregate[4] = "деньгами";
            myAggregate[5] = "????????";
            Iterator iterator = myAggregate.CreateIterator();
            object element;
            Console.WriteLine(iterator.First());
            while (!iterator.IsDone())
            {
                element = iterator.Next();
                Console.WriteLine(element);
            }

        }
    }
}
