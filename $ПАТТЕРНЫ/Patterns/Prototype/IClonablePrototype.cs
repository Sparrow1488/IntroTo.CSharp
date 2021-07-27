using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public interface IClonablePrototype
    {
        GovernPanel DeepClone();
        GovernPanel ShallowClone();
    }
}
