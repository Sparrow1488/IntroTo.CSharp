namespace AbstractFactory.Bmw
{
    internal class BmwFactory : AbstractCarFactory
    {
        public override AbstractCorps CreateCorps()
        {
            return new BmwCorps();
        }

        public override AbstractTransmission CreateTransmission()
        {
            return new BmwTransmission();
        }

        public override AbstractWeels CreateWeels()
        {
            return new BmwWeels();
        }
    }
}
