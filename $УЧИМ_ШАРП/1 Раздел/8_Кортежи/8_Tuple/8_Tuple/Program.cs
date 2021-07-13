using System;
using System.Collections.Generic;

namespace _8_Tuple
{
    internal class Program
    {
        // <<< = = = КОРТЕЖИ = = = >>>
        // Кортеж -  упорядоченный набор фиксированной длины
        public static void Main()
        {
            CalculateTuple();
            (int, string) tupaTuple;
            tupaTuple = TransformValues(228, "ХОЧУ РОЛЛОВ!!!");
            Report(tupaTuple);
            (Entity,string)tuple = GetEntityAndState();
            Report(string.Format("Entity type {0}, status {1}", tuple.Item1, tuple.Item2));
        }
        private static void Report(object message)
        {
            Console.WriteLine(message);
        }
        private static (int, string) TransformValues(int number, string row)
        {
            number += 1488;
            var joinedRow = string.Join(row, "!");
            return (number, joinedRow);
        }
        private static void CalculateTuple()
        {
            var tuple = (10, 12);

            Console.WriteLine(tuple);
            tuple.Item1 += 120; // можно манипулировать отдельными элементами кортежа
            Console.WriteLine(tuple);
        }
        private static (Entity, string) GetEntityAndState()
        {
            var entity = new Entity();
            entity.SetName("Хачерс");
            return (entity, "Adminus");
        }
    }

    internal class Entity
    {
        public string Name { get; private set; }
        public void SetName(string name)
        {
            Name = name;
        }
    }
}
