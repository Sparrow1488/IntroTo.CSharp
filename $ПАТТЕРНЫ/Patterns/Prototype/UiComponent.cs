using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class UiComponent
    {
        public UiComponent(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
}
