using SecuredServices.Core.Attributes;
using System;

namespace SecuredServices.Core
{
    /// <summary>
    ///     Контекст с клиентом, который использует SecuredServices
    /// </summary>
    public class ManagerContext : IManagerContext<int>
    {
        public bool IsAuthorized { get; set; }
        public string Role { get; set; }

        void IManagerContext<int>.AuthorizeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
