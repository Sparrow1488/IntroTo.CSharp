using PrivateServices.Console.Data;
using PrivateServices.Console.Models;

namespace PrivateServices.Console.Services
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
