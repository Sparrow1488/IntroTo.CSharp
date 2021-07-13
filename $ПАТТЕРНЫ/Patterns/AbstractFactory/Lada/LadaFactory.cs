using System;

namespace AbstractFactory.Lada
{
    internal class LadaFactory : AbstractCarFactory
    {
        public override AbstractCorps CreateCorps()
        {
            return new LadaCorps();
        }

        public override AbstractTransmission CreateTransmission()
        {
            return new LadaTransmission();
        }

        public override AbstractWeels CreateWeels()
        {
            return new LadaWeels();
        }
    }
}
