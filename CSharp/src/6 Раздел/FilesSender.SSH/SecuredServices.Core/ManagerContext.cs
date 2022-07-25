using SecuredServices.Core.Attributes;
using System;

namespace SecuredServices.Core
{
    /// <summary>
    ///     Контекст с клиентом, который использует SecuredServices
    /// </summary>
    public class ManagerContext : IManagerSession<int>
    {
        public bool IsAuthorized { get; set; }
        public string Role { get; set; }

        void IManagerSession<int>.AuthorizeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
