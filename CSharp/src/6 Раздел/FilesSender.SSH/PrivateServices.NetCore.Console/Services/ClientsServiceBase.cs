using SecuredServices.Core.Console.Data;
using SecuredServices.Core.Console.Models;

namespace SecuredServices.Core.Console.Services
{
    internal abstract class ClientsServiceBase
    {
        public ClientsServiceBase(ClientsStorage storage)
        {
            Storage = storage;
        }

        protected ClientsStorage Storage { get; }

        public abstract Client AuthorizeByName(string name);
        public abstract Client Edit(Client client);
    }
}
