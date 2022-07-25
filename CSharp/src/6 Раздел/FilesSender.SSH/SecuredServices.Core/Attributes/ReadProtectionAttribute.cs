namespace SecuredServices.Core.Attributes
{
    public class ReadProtectionAttribute : PolicyProtectionAttribute
    {
        public ReadProtectionAttribute()
        {
        }

        public ReadProtectionAttribute(string policy) : base(policy)
        {
        }
    }
}
