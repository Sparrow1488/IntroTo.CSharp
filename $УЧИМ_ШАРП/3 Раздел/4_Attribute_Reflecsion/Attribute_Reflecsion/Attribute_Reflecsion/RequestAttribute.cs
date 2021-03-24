using System;

namespace Attribute_Reflecsion
{
    public class RequestAttribute : Attribute
    {
        public RequestAttribute(string action)
        {
            Action = action;
        }
        public RequestAttribute() { }
        public string Action { get; }
        public override string ToString()
        {
            return Action;
        }
    }
}
