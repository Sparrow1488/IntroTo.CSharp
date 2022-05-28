using SecuredServices.Core.Attributes;
using SecuredServices.Core.Tests.TestPolicy.Roles;

namespace SecuredServices.Core.Tests.TestEntities
{
    public class Group : Identity
    {
        [ChangeProtection(TestRole.Editor)]
        public string Title { get; set; }

        [ChangeProtection(TestRole.Editor)]
        [ReadProtection(TestRole.User)]
        public string Description { get; set; }

        [ChangeProtection(TestRole.Editor)]
        [ReadProtection(TestRole.User)]
        public bool IsPrivate { get; set; } = false;
    }
}
