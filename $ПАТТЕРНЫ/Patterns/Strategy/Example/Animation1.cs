using System;

namespace Strategy.Example
{
    public class Animation1 : IAnimation
    {
        public void Animation()
        {
            Console.WriteLine("Воспроизводится первая анимация");
        }
    }
}
