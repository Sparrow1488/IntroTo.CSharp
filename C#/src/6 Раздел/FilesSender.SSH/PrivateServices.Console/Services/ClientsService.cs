using PrivateServices.Console.Data;
using PrivateServices.Console.Exceptions;
using PrivateServices.Console.Models;
using PrivateServices.Console.SecurityValidators;
using PrivateServices.Console.Sessions;

namespace PrivateServices.Console.Services
{
    internal class ClientsService : ClientsServiceBase
    {
        public ClientsService(
            ClientsStorage storage,
            SecurityValidator<Client> securityValidator) : base(storage)
        {
            _securityValidator = securityValidator;
        }

        private readonly SecurityValidator<Client> _securityValidator;

        /// <summary>
        ///     Authorize user
        /// </summary>
        /// <exception cref="AuthorizeFailedException"></exception>
        public override Client AuthorizeByName(string name)
        {
            var foundClient = Storage.Clients.SingleOrDefault(x => x.Name == name);
            Session.Current = new Session()
            {
                Client = foundClient
            };
            return foundClient ?? throw new AuthorizeFailedException();
        }

        public override Client Edit(Client client)
        {
            var clientDb = Storage.Clients.SingleOrDefault(x => x.Id == client.Id);
            clientDb = clientDb ?? throw new ClientNotFoundException();
            if (_securityValidator.IsSecured(client))
            {
                clientDb.Name = client.Name;
                clientDb.Role = client.Role; // TODO: может назначать только SystemRole.Admin
            }
            else
            {
                throw new AccessDeniedException();
            }
            return clientDb;
        }
    }
}
