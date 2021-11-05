using System;

namespace AbstractFactory.Bmw
{
    internal class BmwTransmission : AbstractTransmission
    {
        public override void Interact(AbstractWeels weels)
        {
            Console.WriteLine("К трансмиссии Bmw прикрутили колеса");
        }
    }
}
