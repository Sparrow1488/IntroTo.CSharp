using System;

namespace AbstractFactory.Lada
{
    internal class LadaTransmission : AbstractTransmission
    {
        public override void Interact(AbstractWeels weels)
        {
            Console.WriteLine("К трансмиссии Лады прикрутили колеса");
        }
    }
}
