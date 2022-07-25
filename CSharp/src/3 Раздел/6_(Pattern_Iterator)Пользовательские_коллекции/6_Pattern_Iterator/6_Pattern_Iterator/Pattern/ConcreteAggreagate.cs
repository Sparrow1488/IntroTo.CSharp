using System.Collections;

namespace _6_Pattern_Iterator.Pattern
{
    public class ConcreteAggreagate : Aggregate
    {
        private ArrayList _collection = new ArrayList();

        public override object this[int index] 
        { 
            get => _collection[index];
            set => _collection.Insert(index, value); 
        }

        public override Iterator CreateIterator()
        {
            var iterator = new ConcreteIterator(this);
            return iterator;
        }
        public int Count
        {
            get => _collection.Count;
        }
    }
}
