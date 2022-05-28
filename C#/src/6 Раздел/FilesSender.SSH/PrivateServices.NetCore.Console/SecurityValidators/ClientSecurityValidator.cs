using PrivateServices.NetCore.Console.Attributes;
using PrivateServices.NetCore.Console.Data;
using PrivateServices.NetCore.Console.Models;
using PrivateServices.NetCore.Console.Roles;
using System;
using System.Linq;
using System.Reflection;

namespace PrivateServices.NetCore.Console.SecurityValidators
{
    internal class ClientSecurityValidator : EntityProtector<Client>
    {
        public ClientSecurityValidator(ClientsStorage storage)
        {
            _storage = storage;
        }

        private readonly ClientsStorage _storage;

        public override bool IsSecured(Client entityToSecure)
        {
            throw new NotImplementedException();
            bool result = false;
            var props = entityToSecure.GetType().GetProperties();
            if (props.Any())
            {
                var user = _storage.Clients.First(x => x.Id == entityToSecure.Id);
                foreach (var prop in props)
                {
                    var editSecureAttr = prop.GetCustomAttributes(typeof(EditSecurityAttribute), false).FirstOrDefault() as EditSecurityAttribute;
                    if (editSecureAttr is null)
                        continue;

                    var userProp = user.GetType().GetProperties().First(x => x.Name == prop.Name);
                    var a = prop.GetValue(entityToSecure);
                    var b = userProp.GetValue(user);
                    var isPropChanged = a != b;
                    if (isPropChanged)
                    {
                        var minRoleToChange = editSecureAttr.MinimumRole;
                        if (user.Role != minRoleToChange)
                        {
                            return false;
                        }
                    }
                    result = true;
                }
            }
            else
            {
                result = true;
            }
            return result;
        }

        public override bool IsSecured(Client entityToSecure, Client baseEntity)
        {
            var allPropsSecured = false;
            var securedProps = GetSecuredProperties(entityToSecure);
            foreach (var prop in securedProps)
            {
                var editSecurityPassed = IsEditSecurityPassed(prop, entityToSecure, baseEntity);
                allPropsSecured = editSecurityPassed;
            }
            return allPropsSecured;
        }

        private PropertyInfo[] GetSecuredProperties(Client client)
        {
            var props = client.GetType().GetProperties().Where(x => x.GetCustomAttributes(typeof(SecurityAttribute)).Any()).ToArray();
            return props;
        }

        private bool IsEditSecurityPassed(PropertyInfo property, Client editedClient, Client baseClient)
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

        private bool IsClientRoleGreaterOrEqualThanMinimalToEdit(Client editedClient, string minimalRoleToEdit)
        {
            var minimalRoleRank = SystemRole.GetRoleRank(minimalRoleToEdit);
            var clientRoleRank = SystemRole.GetRoleRank(editedClient.Role);
            if (clientRoleRank >= minimalRoleRank)
            {
                return true;
            }
            return false;
        }
    }
}
