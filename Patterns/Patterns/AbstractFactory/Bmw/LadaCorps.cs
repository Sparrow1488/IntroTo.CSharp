using System;

namespace AbstractFactory.Bmw
{
    internal class BmwCorps : AbstractCorps
    {
        public override void Interact(AbstractTransmission transmission)
        {
            Console.WriteLine("К корпусу Bmw прибили трансмиссию");
        }
    }
}
