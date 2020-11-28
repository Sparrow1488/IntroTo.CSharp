using System;

namespace Interfaces
{
    public class BMW : ICar
    {
        public string Name { get; private set; } = "BMW";
        public int Move(int distance)
        {
            int speed = 80;
            return distance / speed;
        }
    }
}
