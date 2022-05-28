namespace SecuredServices.Core.Attributes
{
    public class ChangeProtectionAttribute : ProtectionAttribute
    {
        public ChangeProtectionAttribute() { }

        public ChangeProtectionAttribute(string policy) =>
            Policy = policy;

        public string Policy { get; }
    }
}
