using SecuredServices.Core.Console.Data;
using SecuredServices.Core.Console.Exceptions;
using SecuredServices.Core.Console.Models;
using SecuredServices.Core.Console.SecurityValidators;
using System.Linq;

namespace SecuredServices.Core.Console.Services
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
            var clientDb = _storage.Clients.SingleOrDefault(x => x.Id == edited.Id)
                            ?? throw new ClientNotFoundException();
            if (_protector.IsProtected(edited, clientDb))
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
