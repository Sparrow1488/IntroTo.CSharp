using PrivateServices.NetCore.Console.Models;
using PrivateServices.NetCore.Console.Services.Arguments;

namespace PrivateServices.NetCore.Console.Services
{
    internal interface IClientsModeratorService
    {
        Client Edit(EditClientModeratorArgument argument);
        void DeleteById(int clientId);
    }
}
