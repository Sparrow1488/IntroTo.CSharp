using SecuredServices.Core.Console.Models;

namespace SecuredServices.Core.Console.Sessions
{
    internal class Session
    {
        public Client Client { get; internal set; } = new Client();

        public static Session Current { get; internal set; } = new Session();
    }
}
