using PrivateServices.NetCore.Console.Models;
using PrivateServices.NetCore.Console.Services.Arguments;

namespace PrivateServices.NetCore.Console.Services
{
    internal interface IClientsService
    {
        Client Edit(EditClientArgument argument);
    }
}
