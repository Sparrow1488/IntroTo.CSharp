using PrivateServices.Console.Attributes;
using PrivateServices.Console.Data;
using PrivateServices.Console.Models;

namespace PrivateServices.Console.SecurityValidators
{
    internal class ClientSecurityValidator : SecurityValidator<Client>
    {
        public ClientSecurityValidator(ClientsStorage storage)
        {
            _storage = storage;
        }

        private readonly ClientsStorage _storage;

        public override bool IsSecured(Client entityToSecure)
        {
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
    }
}
