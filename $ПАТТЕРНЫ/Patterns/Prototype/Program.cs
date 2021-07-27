using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var components = new List<UiComponent>()
            {
                new UiComponent("Кнопка 1"),
                new UiComponent("Кнопка 2"),
                new UiComponent("Header"),
                new UiComponent("Head")
            };
            var panel = new GovernPanel(components);
            panel.Id = 1;
            var prototype = panel.DeepClone();
            prototype.Id = 2;

            panel.Display();
            prototype.Display();

        }
    }
}
