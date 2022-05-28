using System.Collections.Generic;

namespace PrivateServices.NetCore.Console.SecurityValidators
{
    internal abstract class EntityProtector<TEntity>
    {
        private readonly List<string> _errors = new List<string>();

        public IEnumerable<string> Errors => _errors;

        public abstract bool IsSecured(TEntity entityToSecure);
        public abstract bool IsSecured(TEntity entityToSecure, TEntity baseEntity);
    }
}
