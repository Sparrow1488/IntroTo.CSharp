using PrivateServices.Console.Models;
using PrivateServices.Console.Services.Arguments;

namespace PrivateServices.Console.Services
{
    internal interface IClientsModeratorService
    {
        Client Edit(EditClientModeratorArgument argument);
    }
}
