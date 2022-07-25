using SecuredServices.Core.Console.Models;
using System.Collections.Generic;

namespace SecuredServices.Core.Console.SecurityValidators
{
    public interface IEntityProtector<TEntity, TRole> : IEntityProtector
        where TEntity : class
    {
        bool IsProtected(TEntity modifiedEntity, TEntity baseEntity);
    }

    public interface IEntityProtector
    {
        ManagerContext ManagerContext { get; protected set; }
        IEnumerable<string> Errors { get; }
    }
}
