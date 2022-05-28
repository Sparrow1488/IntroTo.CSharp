using Microsoft.Extensions.DependencyInjection;
using SecuredServices.Core.Console.Attributes;
using SecuredServices.Core.Console.Models;
using SecuredServices.Core.Console.Roles;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SecuredServices.Core.Console.SecurityValidators
{
    public class EntityProtector<TEntity> : IEntityProtector<TEntity, string>
        where TEntity : class
    {
        public EntityProtector(
            IServiceCollection services,
            ManagerContext context)
        {
            _services = services;
            ManagerContext = context;
        }

        protected readonly List<string> errors = new List<string>();
        private readonly IServiceCollection _services;

        public IEnumerable<string> Errors => errors;
        public ManagerContext ManagerContext { get; protected set; }
        ManagerContext IEntityProtector.ManagerContext { get; set; }

        IEnumerable<string> IEntityProtector.Errors => throw new System.NotImplementedException();

        public bool IsProtected(TEntity modifiedEntity, TEntity baseEntity)
        {
            var allPropsSecured = false;
            var securedProps = GetSecuredProperties(modifiedEntity);
            foreach (var prop in securedProps)
            {
                var editSecurityPassed = IsEditSecurityPassed(prop, modifiedEntity, baseEntity);
                allPropsSecured = editSecurityPassed;
            }
            return allPropsSecured;
        }

        private PropertyInfo[] GetSecuredProperties<TEntity>(TEntity client)
        {
            var props = client.GetType().GetProperties().Where(x => x.GetCustomAttributes(typeof(SecurityAttribute)).Any()).ToArray();
            return props;
        }

        private bool IsEditSecurityPassed(PropertyInfo property, TEntity editedClient, TEntity baseClient)
        {
            var securityAttr = property.GetCustomAttribute(typeof(EditSecurityAttribute));
            if (securityAttr is EditSecurityAttribute editAttr)
            {
                var baseClientPropValue = baseClient.GetType().GetProperty(property.Name).GetValue(baseClient);
                var editedClientPropertyValue = property.GetValue(editedClient);
                if (baseClientPropValue != editedClientPropertyValue)
                {
                    if (!IsClientRoleGreaterOrEqualThanMinimalToEdit(editedClient, editAttr.MinimumRole))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        private bool IsClientRoleGreaterOrEqualThanMinimalToEdit(
            TEntity editedClient, string minimalRoleToEdit)
        {
            var minimalRoleRank = SystemRole.GetRoleRank(minimalRoleToEdit);
            var clientRoleRank = SystemRole.GetRoleRank(editedClient.Role);
            if (clientRoleRank >= minimalRoleRank)
            {
                return true;
            }
            return false;
        }

        bool IEntityProtector<TEntity, string>.IsProtected(TEntity modifiedEntity, TEntity baseEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}
