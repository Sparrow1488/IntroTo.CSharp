using SecuredServices.Core.Attributes;
using SecuredServices.Core.Tests.TestPolicy.Roles;

namespace SecuredServices.Core.Tests.TestEntities
{
    public class Group : Identity
    {
        [ChangeProtection(TestRole.Editor)]
        public string Title { get; set; }
        [ChangeProtection(TestRole.Editor)]
        public string Description { get; set; }
        [ChangeProtection(TestRole.Editor)]
        public bool IsPrivate { get; set; } = false;

        [ChangeProtection(TestRole.User)]
        public string UserProp { get; set; }

        [ChangeProtection]
        public string NotConfigmedProp { get; set; }
    }
}
