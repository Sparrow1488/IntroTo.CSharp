using SecuredServices.Core.Console.Models;
using SecuredServices.Core.Console.Services.Arguments;

namespace SecuredServices.Core.Console.Services
{
    internal interface IClientsService
    {
        Client Edit(EditClientArgument argument);
    }
}
