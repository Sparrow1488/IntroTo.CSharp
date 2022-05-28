using SecuredServices.Core.Attributes;

namespace SecuredServices.Core.Tests.TestPolicy.Roles
{
    public class TestRole
    {
        [Policy(rank: 0)]
        public const string NotConfirmed = nameof(NotConfirmed);
        [Policy(rank: 1)]
        public const string User = nameof(User);
        [Policy(rank: 2)]
        public const string Editor = nameof(Editor);
    }
}
