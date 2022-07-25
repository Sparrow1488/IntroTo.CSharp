namespace SecuredServices.Core.Attributes
{
    public abstract class PolicyProtectionAttribute : ProtectionAttribute
    {
        public PolicyProtectionAttribute() { }
        public PolicyProtectionAttribute(string policy)
        {
            Policy = policy;
        }

        public string Policy { get; }
    }
}
