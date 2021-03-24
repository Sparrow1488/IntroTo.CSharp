namespace Attribute_Reflecsion
{
    public abstract class Package
    {
        public Package(object obj)
        {
            SendObject = obj;
        }
        public object SendObject { get; }
    }
}
