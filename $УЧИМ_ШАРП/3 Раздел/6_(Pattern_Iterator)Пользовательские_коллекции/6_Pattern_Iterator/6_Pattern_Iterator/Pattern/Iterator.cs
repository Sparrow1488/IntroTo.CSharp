namespace _6_Pattern_Iterator.Pattern
{
    public abstract class Iterator
    {
        public Iterator(Aggregate aggregate)
        {
        }
        public abstract object GetCurrent();
        public abstract object First();
        public abstract bool IsDone();
        public abstract object Next();
    }
}
