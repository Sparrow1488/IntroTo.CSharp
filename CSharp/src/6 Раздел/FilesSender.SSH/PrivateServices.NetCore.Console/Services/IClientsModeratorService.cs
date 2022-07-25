using SecuredServices.Core.Console.Models;
using SecuredServices.Core.Console.Services.Arguments;

namespace SecuredServices.Core.Console.Services
{
    internal interface IClientsModeratorService
    {
        Client Edit(EditClientModeratorArgument argument);
        void DeleteById(int clientId);
    }
}
