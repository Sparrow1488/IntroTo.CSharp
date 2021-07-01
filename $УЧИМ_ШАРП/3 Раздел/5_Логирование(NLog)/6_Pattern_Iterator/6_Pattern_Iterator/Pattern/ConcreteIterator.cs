using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Pattern_Iterator.Pattern
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggreagate _concreteAggregate;
        private int current;
        public ConcreteIterator(ConcreteAggreagate aggregate) : base(aggregate)
        {
            _concreteAggregate = aggregate;
        }

        public override object First()
        {
            return _concreteAggregate[0];
        }

        public override object GetCurrent()
        {
            return _concreteAggregate[current];
        }

        public override bool IsDone()
        {
            return current >= _concreteAggregate.Count-1;
        }

        public override object Next()
        {
            object item = null;
            if (current < _concreteAggregate.Count - 1)
                item = _concreteAggregate[++current];
            return item;
        }
    }
}
