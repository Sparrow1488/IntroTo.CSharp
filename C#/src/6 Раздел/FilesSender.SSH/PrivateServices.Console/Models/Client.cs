using PrivateServices.Console.Attributes;
using PrivateServices.Console.Roles;

namespace PrivateServices.Console.Models
{
    internal class Client : Identity
    {
        public string Name { get; set; } = "Anon";
        [EditSecurity(SystemRole.Admin)]
        public string Role { get; set; } = SystemRole.Anon;

        public Client Clone()
        {
            return new Client()
            {
                Id = Id,
                Name = Name,
                Role = Role
            };
        }
    }
}
