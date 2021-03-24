namespace Attribute_Reflecsion
{
    public class UploadPhoto : Package
    {
        [Request("domen_name/upload/myAttaches/")]
        public UploadPhoto(object obj) : base(obj) { }
    }
}
