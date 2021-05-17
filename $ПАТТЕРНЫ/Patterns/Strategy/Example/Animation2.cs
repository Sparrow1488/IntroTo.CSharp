using System;

namespace Strategy.Example
{
    public class Animation2 : IAnimation
    {
        public void Animation()
        {
            Console.WriteLine("Воспроизводится вторая анимация");
        }
    }
}
