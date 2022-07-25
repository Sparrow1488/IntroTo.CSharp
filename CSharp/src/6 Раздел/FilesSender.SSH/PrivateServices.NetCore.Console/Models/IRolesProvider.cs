using System.Collections.Generic;

namespace SecuredServices.Core.Console.Models
{
    public interface IRolesProvider<TRole>
    {
        IEnumerable<TRole> Roles { get; }
        bool IsRole(string row);
    }
}
