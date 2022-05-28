using PrivateServices.NetCore.Console.Data;
using PrivateServices.NetCore.Console.Exceptions;
using PrivateServices.NetCore.Console.Models;
using PrivateServices.NetCore.Console.SecurityValidators;
using System.Linq;

namespace PrivateServices.NetCore.Console.Services
{
    internal class UniversalClientsService
    {
        public UniversalClientsService(
            ClientsStorage storage,
            EntityProtector<Client> protector)
        {
            _storage = storage;
            _protector = protector;
        }

        private readonly ClientsStorage _storage;
        private readonly EntityProtector<Client> _protector;

        public virtual Client GetById(int id)
        {
            return _storage.Clients.First(x => x.Id == id);
        }

        public virtual Client Edit(Client edited)
        {
            var clientDb = _storage.Clients.First(x => x.Id == edited.Id);
            if (_protector.IsSecured(edited, clientDb))
            {
                clientDb.Name = edited.Name;
                clientDb.Role = edited.Role;
                // save in db
                return clientDb;
            }
            throw new AccessDeniedException();
        }
    }
}
