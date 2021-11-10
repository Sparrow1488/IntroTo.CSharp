using System;

namespace Attribute_Reflecsion
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class UserInfoAttribute : Attribute
    {
        public UserInfoAttribute(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public UserInfoAttribute() { }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
