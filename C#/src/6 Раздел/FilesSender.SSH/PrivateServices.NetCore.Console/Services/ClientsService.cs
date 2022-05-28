using PrivateServices.NetCore.Console.Data;
using PrivateServices.NetCore.Console.Exceptions;
using PrivateServices.NetCore.Console.Models;
using PrivateServices.NetCore.Console.SecurityValidators;
using PrivateServices.NetCore.Console.Services.Arguments;
using PrivateServices.NetCore.Console.Sessions;
using System.Linq;

namespace PrivateServices.NetCore.Console.Services
{
    internal class ClientsService : ClientsServiceBase, IClientsService, IClientsModeratorService
    {
        public ClientsService(
            ClientsStorage storage,
            EntityProtector<Client> securityValidator) : base(storage)
        {
            _securityValidator = securityValidator;
        }

        private readonly EntityProtector<Client> _securityValidator;

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
            return foundClient?.Clone() ?? throw new AuthorizeFailedException();
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

        public Client Edit(EditClientArgument argument)
        {
            var clientDb = GetClientByIdOrThrow(argument.Id);
            clientDb.Name = argument.EditedName;
            // save in db
            return clientDb;
        }

        public Client Edit(EditClientModeratorArgument argument)
        {
            var clientDb = GetClientByIdOrThrow(argument.Id);
            clientDb.Name = argument.EditedName;
            clientDb.Role = argument.EditedRole;
            // save in db
            return clientDb;
        }

        private Client GetClientByIdOrThrow(int clientId)
        {
            var clientDb = Storage.Clients.SingleOrDefault(x => x.Id == clientId);
            clientDb = clientDb ?? throw new ClientNotFoundException();
            return clientDb;
        }

        public void DeleteById(int clientId)
        {
            // типа удалил
        }
    }
}
