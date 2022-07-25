using PrivateServices.Console.Models;
using PrivateServices.Console.Services.Arguments;

namespace PrivateServices.Console.Services
{
    internal interface IClientsService
    {
        Client Edit(EditClientArgument argument);
    }
}
