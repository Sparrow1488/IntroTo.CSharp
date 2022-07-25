using System;

namespace AbstractFactory.Lada
{
    internal class LadaCorps : AbstractCorps
    {
        public override void Interact(AbstractTransmission transmission)
        {
            Console.WriteLine("К корпусу Лады прибили трансмиссию");
        }
    }
}
