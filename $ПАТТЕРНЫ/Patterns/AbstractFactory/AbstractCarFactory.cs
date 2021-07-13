namespace AbstractFactory
{
    internal abstract class AbstractCarFactory
    {
        public abstract AbstractCorps CreateCorps();
        public abstract AbstractTransmission CreateTransmission();
        public abstract AbstractWeels CreateWeels();
    }
}
