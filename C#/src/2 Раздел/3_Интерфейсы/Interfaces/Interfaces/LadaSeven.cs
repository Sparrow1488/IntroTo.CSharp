using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class LadaSeven : ICar
    {
        public string Name { get; private set; } = "Lada7";

        public int Move(int distance)
        {
            int speed = 40;
            return distance / speed;
        }
    }
}
