using SecuredServices.Core.Console.Models;
using SecuredServices.Core.Console.Roles;
using System.Collections.Generic;

namespace SecuredServices.Core.Console.Data
{
    internal class ClientsStorage
    {
        public IEnumerable<Client> Clients = new Client[]
        {
            new Client()
            {
                Id = 1,
                Name = "Sparrow",
                Role = SystemRole.Admin
            },
            new Client()
            {
                Id = 2,
                Name = "Valentin",
                Role = SystemRole.Manager
            },
            new Client()
            {
                Id = 3,
                Name = "Ilya",
                Role = SystemRole.User
            },
            new Client()
            {
                Id = 4,
                Name = "Vasya",
                Role = SystemRole.User
            }
        };
    }
}
