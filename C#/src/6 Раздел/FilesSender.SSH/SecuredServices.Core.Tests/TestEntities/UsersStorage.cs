using SecuredServices.Core.Tests.TestPolicy.Roles;
using System.Collections.Generic;

namespace SecuredServices.Core.Tests.TestEntities
{
    public class UsersStorage
    {
        public IEnumerable<User> Users = new User[]
        {
            new User()
            {
                Id = 1,
                Role = TestRole.User
            },
            new User()
            {
                Id = 2,
                Role = TestRole.Editor
            }
        };
    }
}
