using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Cyborg : ICar, IPerson
    {
        public int Speed { get; private set; } = 20;
        public int SpeedMove { get; private set; } = 120;
        public string Name { get; private set; } = "<N 676-23 model:4>";
        int IPerson.Move(int distance)
        {
            return distance / Speed;
        }

        int ICar.Move(int distance)
        {
            return distance / SpeedMove;
        }
    }
}
