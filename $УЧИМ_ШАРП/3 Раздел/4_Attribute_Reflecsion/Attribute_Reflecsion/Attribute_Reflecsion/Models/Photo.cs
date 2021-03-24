namespace Attribute_Reflecsion.Models
{
    [UserInfo(Program.UserName, 1488)]
    public class Photo
    {
        public string Description { get; }
        public string Extension { get; }
        public Photo(string desc, string extension)
        {
            Description = desc;
            Extension = extension;
        }
    }
}
