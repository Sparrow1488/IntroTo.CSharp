namespace SecuredServices.Core.Attributes
{
    public class ChangeProtectionAttribute : PolicyProtectionAttribute
    {
        public ChangeProtectionAttribute()
        {
        }

        public ChangeProtectionAttribute(string policy) : base(policy)
        {
        }
    }
}
